//Javascript name: My Date Time Picker
//Date created: 16-Nov-2007 23:19
//Scripter:Gaurav sharma(Rensol Systems Pvt Ltd)
//Thanks to : Gaurav sharma
//Website: http://www.Gauravsharma.com
//Copyright (c) 
//FileName: DateTimePicker.js
//Version: 0.8
//Contact: contact@rainforestnet.com
// Note: Permission given to use this script in ANY kind of applications if
//       header lines are left unchanged.

//Global variables
var winCal;
var dtToday=new Date();
var Cal;
var docCal;
var MonthName=["01", "02", "03", "04", "05", "06","07", 
	"08", "09", "10", "11", "12"];
var WeekDayName=["Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"];	
var exDateTime;//Existing Date and Time

//Configurable parameters
var cnTop="200";//top coordinate of calendar window.
var cnLeft="450";//left coordinate of calendar window
var WindowTitle ="Contec Global";//Date Time Picker title.
var WeekChar=2;//number of character for week day. if 2 then Mo,Tu,We. if 3 then Mon,Tue,Wed.
var CellWidth=20;//Width of day cell.
var DateSeparator="-";//Seperator changed by Gaurav Sharma on 30-08-2008
var TimeMode=24;//default TimeMode value. 12 or 24

var ShowLongMonth=true;//Show long month name in Calendar header. example: "January".
var ShowMonthYear=true;//Show Month and Year in Calendar header.
var MonthYearColor="#000000";//Font Color of Month and Year in Calendar header.
var WeekHeadColor="#C1D3FB";//Background Color in Week header.
var SundayColor="#9396EE";//Background color of Sunday.
var SaturdayColor="#9396EE";//Background color of Saturday.
var WeekDayColor="Transparent";//Background color of weekdays.
var FontColor="#000000";//color of font in Calendar day cell.
var TodayColor="#8EB6F4";//Background color of today.
var SelDateColor="#0092DD";//Backgrond color of selected date in textbox.
var YrSelColor="#384467";//color of font of Year selector.
var ThemeBg="../Images/Cal_BG.gif";//Background image of Calendar window.
//end Configurable parameters
//end Global variable

function NewCal(pCtrl,pFormat,pShowTime,pTimeMode,strt,ed)
{
 
	Cal=new Calendar(dtToday);
	if ((pShowTime!=null) && (pShowTime))
	{
		Cal.ShowTime=true;
		if ((pTimeMode!=null) &&((pTimeMode=='12')||(pTimeMode=='24')))
		{
			TimeMode=pTimeMode;
		}		
	}	
	if (pCtrl!=null)
		Cal.Ctrl=pCtrl;
	if (pFormat!=null)
		Cal.Format=pFormat.toUpperCase();
	
	exDateTime=document.getElementById(pCtrl).value;
	if (exDateTime!="")//Parse Date String
	{
		var Sp1;//Index of Date Separator 1
		var Sp2;//Index of Date Separator 2 
		var tSp1;//Index of Time Separator 1
		var tSp1;//Index of Time Separator 2
		var strMonth;
		var strDate;
		var strYear;
		var intMonth;
		var YearPattern;
		var strHour;
		var strMinute;
		var strSecond;
		//parse month
		Sp1=exDateTime.indexOf(DateSeparator,0)
		Sp2=exDateTime.indexOf(DateSeparator,(parseInt(Sp1)+1));
		
		if ((Cal.Format.toUpperCase()=="DDMMYYYY") || (Cal.Format.toUpperCase()=="DDMMMYYYY"))
		{
			strMonth=exDateTime.substring(Sp1+1,Sp2);
			strDate=exDateTime.substring(0,Sp1);
		}
		else if ((Cal.Format.toUpperCase()=="MMDDYYYY") || (Cal.Format.toUpperCase()=="MMMDDYYYY"))
		{
			strMonth=exDateTime.substring(0,Sp1);
      
			strDate=exDateTime.substring(Sp1+1,Sp2);
		}
		if (isNaN(strMonth))
			intMonth=Cal.GetMonthIndex(strMonth);
		else
			intMonth=parseInt(strMonth,10)-1;	
		if ((parseInt(intMonth,10)>=0) && (parseInt(intMonth,10)<12))
			Cal.Month=intMonth;
		//end parse month
		//parse Date
		if ((parseInt(strDate,10)<=Cal.GetMonDays()) && (parseInt(strDate,10)>=1))
			Cal.Date=strDate;
		//end parse Date
		//parse year
		strYear=exDateTime.substring(Sp2+1,Sp2+5);
		YearPattern=/^\d{4}$/;
		if (YearPattern.test(strYear))
			Cal.Year=parseInt(strYear,10);
		//end parse year
		//parse time
		if (Cal.ShowTime==true)
		{
			tSp1=exDateTime.indexOf(":",0)
			tSp2=exDateTime.indexOf(":",(parseInt(tSp1)+1));
			strHour=exDateTime.substring(tSp1,(tSp1)-2);
			Cal.SetHour(strHour);
			strMinute=exDateTime.substring(tSp1+1,tSp2);
			Cal.SetMinute(strMinute);
			strSecond=exDateTime.substring(tSp2+1,tSp2+3);
			Cal.SetSecond(strSecond);
		}	
	}
	winCal=window.open("","DateTimePicker","toolbar=none,status=none,menubar=none,width=225px,height=175px,resizable=no,top="+cnTop+",left="+cnLeft);
	docCal=winCal.document;
	RenderCal(strt,ed);
}

function RenderCal(strt,ed)
{

	var vCalHeader;
	var vCalData;
	var vCalTime;
	var i;
	var j;
	var SelectStr;
	var vDayCount=00;
	var vFirstDay;

	docCal.open();
	docCal.writeln("<html><head><title>"+WindowTitle+"</title>");
	docCal.writeln("<script>var winMain=window.opener;</script>");
	docCal.writeln("</head><body background='"+ThemeBg+"' link="+FontColor+" vlink="+FontColor+"  style=\"margin:0px;padding:0px;top:0px;left:0px;\"><form name='Calendar'>");

	vCalHeader="<table style=\"border:1px solid #C1D3FB\" cellpadding=1 cellspacing=1 width='100%' align=\"center\" valign=\"top\">\n";
	//Month Selector
	vCalHeader+="<tr>\n<td colspan='7' style=\"border:1px solid #C1D3FB\"><table border=0 width='100%' cellpadding=0 cellspacing=0><tr><td align='left'>\n";
	vCalHeader += "<select style=\"font-size:11px; width:80px; height:15px; font-family:Arial\" name=\"MonthSelector\" onChange=\"javascript:winMain.Cal.SwitchMth(this.selectedIndex);winMain.RenderCal(" + strt + "," + ed + ");\">\n";
	for (i=00;i<12;i++)
	{
		if (i==Cal.Month)
			SelectStr="Selected";
		else
			SelectStr="";	
		vCalHeader+="<option "+SelectStr+" value >"+MonthName[i]+"\n";
	}
	vCalHeader+="</select></td>";
	//Year selector
	vCalHeader += "\n<td align='center' > ";
	vCalHeader += "<select style=\"font-size:11px; width:80px; height:15px; font-family:Arial\" name=\"YearSelector\" onChange=\"javascript:winMain.Cal.SwitchYear(this.selectedIndex,'" + strt + "','" + ed + "');winMain.RenderCal(" + strt + "," + ed + ");\" >\n";
	var ut = new Date();
	strCurrYear = ut.getFullYear();
	var StartYear = strCurrYear - strt;
	var EndYear = strCurrYear + ed;
	for (i = StartYear; i < EndYear; i++) {
	    if (i == Cal.Year)
	        SelectStr = "Selected";
	    else
	        SelectStr = "";
	    vCalHeader += "<option " + SelectStr + " value >" + i + "\n";
	}
	vCalHeader += "</select> </td>";
	vCalHeader += "</td></tr></table></td>\n";	
	vCalHeader+="</tr>";
	//Calendar header shows Month and Year
	if (ShowMonthYear)
		vCalHeader+="<tr><td colspan='7'><font face='Arial' style=\"font-size:11px\" align='center' color='"+MonthYearColor+"'><b>"+Cal.GetMonthName(ShowLongMonth)+" "+Cal.Year+"</b></font></td></tr>\n";
	//Week day header
	vCalHeader+="<tr bgcolor="+WeekHeadColor+">";
	for (i=0;i<7;i++)
	{
		vCalHeader+="<td align='center'><font face='Arial' style=\"font-size:11px\">"+WeekDayName[i].substr(0,WeekChar)+"</font></td>";
	}
	vCalHeader+="</tr>";	
	docCal.write(vCalHeader);
	
	//Calendar detail
	CalDate=new Date(Cal.Year,Cal.Month);
	CalDate.setDate(01);
	vFirstDay=CalDate.getDay();
	vCalData="<tr>";
	for (i=00;i<vFirstDay;i++)
	{
		vCalData=vCalData+GenCell();
		vDayCount=vDayCount+01;
	}
	for (j=01;j<=Cal.GetMonDays();j++)
	{
		var strCell;
		vDayCount=vDayCount+01;
		if ((j==dtToday.getDate())&&(Cal.Month==dtToday.getMonth())&&(Cal.Year==dtToday.getFullYear()))
			strCell=GenCell(j,true,TodayColor);//Highlight today's date
		else
		{
			if (j==Cal.Date)
			{
				strCell=GenCell(j,true,SelDateColor);
			}
			else
			{	 
				if (vDayCount%7==0)
					strCell=GenCell(j,false,SaturdayColor);
				else if ((vDayCount+6)%7==0)
					strCell=GenCell(j,false,SundayColor);
				else
					strCell=GenCell(j,null,WeekDayColor);
			}		
		}						
		vCalData=vCalData+strCell;

		if((vDayCount%7==0)&&(j<Cal.GetMonDays()))
		{
			vCalData=vCalData+"</tr>\n<tr>";
		}
	}
	docCal.writeln(vCalData);	
	//Time picker
	if (Cal.ShowTime)
	{
		var showHour;
		showHour=Cal.getShowHour();		
		vCalTime="<tr>\n<td colspan='7' align='center'>";
		vCalTime+="<input type='text' name='hour' maxlength=2 size=1 style=\"WIDTH: 22px\" value="+showHour+" onchange=\"javascript:winMain.Cal.SetHour(this.value)\">";
		vCalTime+=" : ";
		vCalTime+="<input type='text' name='minute' maxlength=2 size=1 style=\"WIDTH: 22px\" value="+Cal.Minutes+" onchange=\"javascript:winMain.Cal.SetMinute(this.value)\">";
		vCalTime+=" : ";
		vCalTime+="<input type='text' name='second' maxlength=2 size=1 style=\"WIDTH: 22px\" value="+Cal.Seconds+" onchange=\"javascript:winMain.Cal.SetSecond(this.value)\">";
		if (TimeMode==12)
		{
			var SelectAm =(parseInt(Cal.Hours,10)<12)? "Selected":"";
			var SelectPm =(parseInt(Cal.Hours,10)>=12)? "Selected":"";

			vCalTime+="<select  name=\"ampm\" onchange=\"javascript:winMain.Cal.SetAmPm(this.options[this.selectedIndex].value);\">";
			vCalTime+="<option "+SelectAm+" value=\"AM\">AM</option>";
			vCalTime+="<option "+SelectPm+" value=\"PM\">PM<option>";
			vCalTime+="</select>";
		}	
		vCalTime+="\n</td>\n</tr>";
		docCal.write(vCalTime);
	}	
	//end time picker
	docCal.writeln("\n</table>");
	docCal.writeln("</form></body></html>");
	docCal.close();
}

function GenCell(pValue,pHighLight,pColor)//Generate table cell with value
{

	var PValue;
	var PCellStr;
	var vColor;
	var vHLstr1;//HighLight string
	var vHlstr2;
	var vTimeStr;
	
	if (pValue==null)
		PValue="";
	else
		PValue=pValue;
	
	if (pColor!=null)
		vColor="bgcolor=\""+pColor+"\"";
	else
		vColor="";	
	if ((pHighLight!=null)&&(pHighLight))
		{vHLstr1="color='red'><b>";vHLstr2="</b>";}
	else
		{vHLstr1=">";vHLstr2="";}	
	
	if (Cal.ShowTime)
	{
		vTimeStr="winMain.document.getElementById('"+Cal.Ctrl+"').value+=' '+"+"winMain.Cal.getShowHour()"+"+':'+"+"winMain.Cal.Minutes"+"+':'+"+"winMain.Cal.Seconds";
		if (TimeMode==12)
			vTimeStr+="+' '+winMain.Cal.AMorPM";
	}	
	else
		vTimeStr="";		
	PCellStr="<td "+vColor+" width="+CellWidth+" align='center' style=\"border:1px solid #C1D3FB\"><font face='Arial' style=\"font-size:11px\" "+vHLstr1+"<a style=\"text-decoration:none\" href=\"javascript:winMain.document.getElementById('"+Cal.Ctrl+"').value='"+Cal.FormatDate(PValue)+"';"+vTimeStr+";window.close();\">"+PValue+"</a>"+vHLstr2+"</font></td>";
	return PCellStr;
}

function Calendar(pDate,pCtrl)
{
	//Properties
  
	this.Date=pDate.getDate();//selected date
	this.Month=pDate.getMonth();//selected month number
	this.Year=pDate.getFullYear();//selected year in 4 digits
	this.Hours=pDate.getHours();	
	
	if (pDate.getMinutes()<10)
		this.Minutes="0"+pDate.getMinutes();
	else
		this.Minutes=pDate.getMinutes();
	
	if (pDate.getSeconds()<10)
		this.Seconds="0"+pDate.getSeconds();
	else		
		this.Seconds=pDate.getSeconds();
		
	this.MyWindow=winCal;
	this.Ctrl=pCtrl;
	this.Format="ddMMyyyy";
	this.Separator=DateSeparator;
	this.ShowTime=false;
	if (pDate.getHours()<12)
		this.AMorPM="AM";
	else
		this.AMorPM="PM";	
}

function GetMonthIndex(shortMonthName)
{

	for (i=0;i<12;i++)
	{
		if (MonthName[i].substring(0,3).toUpperCase()==shortMonthName.toUpperCase())
		{	return i;}
	}
}
Calendar.prototype.GetMonthIndex=GetMonthIndex;

function IncYear()

{	Cal.Year++;}
Calendar.prototype.IncYear=IncYear;

function DecYear()

{	Cal.Year--;}
Calendar.prototype.DecYear=DecYear;
	
function SwitchMth(intMth)

{	Cal.Month=intMth;}
Calendar.prototype.SwitchMth = SwitchMth;

function SwitchYear(intYear,strt) {
    var ut = new Date();
    strCurrYear = ut.getFullYear();
    var StartYrval = strCurrYear - strt;
    Cal.Year = intYear + StartYrval;
}
Calendar.prototype.SwitchYear = SwitchYear;

function SetHour(intHour)
{	
	var MaxHour;
	var MinHour;
	if (TimeMode==24)
	{	MaxHour=23;MinHour=0}
	else if (TimeMode==12)
	{	MaxHour=12;MinHour=1}
	else
	
	var HourExp=new RegExp("^\\d\\d$");
	if (HourExp.test(intHour) && (parseInt(intHour,10)<=MaxHour) && (parseInt(intHour,10)>=MinHour))
	{	
		if ((TimeMode==12) && (Cal.AMorPM=="PM"))
		{
			if (parseInt(intHour,10)==12)
				Cal.Hours=12;
			else	
				Cal.Hours=parseInt(intHour,10)+12;
		}	
		else if ((TimeMode==12) && (Cal.AMorPM=="AM"))
		{
			if (intHour==12)
				intHour-=12;
			Cal.Hours=parseInt(intHour,10);
		}
		else if (TimeMode==24)
			Cal.Hours=parseInt(intHour,10);	
	}
}
Calendar.prototype.SetHour=SetHour;

function SetMinute(intMin)
{
	var MinExp=new RegExp("^\\d\\d$");
	if (MinExp.test(intMin) && (intMin<60))
		Cal.Minutes=intMin;
}
Calendar.prototype.SetMinute=SetMinute;

function SetSecond(intSec)
{	
	var SecExp=new RegExp("^\\d\\d$");
	if (SecExp.test(intSec) && (intSec<60))
		Cal.Seconds=intSec;
}
Calendar.prototype.SetSecond=SetSecond;

function SetAmPm(pvalue)
{
	this.AMorPM=pvalue;
	if (pvalue=="PM")
	{
		this.Hours=(parseInt(this.Hours,10))+12;
		if (this.Hours==24)
			this.Hours=12;
	}	
	else if (pvalue=="AM")
		this.Hours-=12;	
}
Calendar.prototype.SetAmPm=SetAmPm;

function getShowHour()
{
	var finalHour;
    if (TimeMode==12)
    {
    	if (parseInt(this.Hours,10)==0)
		{
			this.AMorPM="AM";
			finalHour=parseInt(this.Hours,10)+12;	
		}
		else if (parseInt(this.Hours,10)==12)
		{
			this.AMorPM="PM";
			finalHour=12;
		}		
		else if (this.Hours>12)
		{
			this.AMorPM="PM";
			if ((this.Hours-12)<10)
				finalHour="0"+((parseInt(this.Hours,10))-12);
			else
				finalHour=parseInt(this.Hours,10)-12;	
		}
		else
		{
			this.AMorPM="AM";
			if (this.Hours<10)
				finalHour="0"+parseInt(this.Hours,10);
			else
				finalHour=this.Hours;	
		}
	}
	else if (TimeMode==24)
	{
		if (this.Hours<10)
			finalHour="0"+parseInt(this.Hours,10);
		else	
			finalHour=this.Hours;
	}	
	return finalHour;	
}				
Calendar.prototype.getShowHour=getShowHour;		

function GetMonthName(IsLong)
{
	var Month=MonthName[this.Month];
	if (IsLong)
		return Month;
	else
		return Month.substr(0,3);
}
Calendar.prototype.GetMonthName=GetMonthName;

function GetMonDays()//Get number of days in a month
{
	var DaysInMonth=[31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];
	if (this.IsLeapYear())
	{
		DaysInMonth[1]=29;
	}	
	return DaysInMonth[this.Month];	
}
Calendar.prototype.GetMonDays=GetMonDays;

function IsLeapYear()
{
	if ((this.Year%4)==0)
	{
		if ((this.Year%100==0) && (this.Year%400)!=0)
		{
			return false;
		}
		else
		{
			return true;
		}
	}
	else
	{
		return false;
	}
}
Calendar.prototype.IsLeapYear=IsLeapYear;

function FormatDate(pDate)
{

	if (this.Format.toUpperCase()=="DDMMYYYY")
		return (pDate+DateSeparator+(this.Month+1)+DateSeparator+this.Year);
	else if (this.Format.toUpperCase()=="DDMMMYYYY")
		return (pDate+DateSeparator+this.GetMonthName(false)+DateSeparator+this.Year);
	else if (this.Format.toUpperCase()=="MMDDYYYY")
		return ((this.Month+1)+DateSeparator+pDate+DateSeparator+this.Year);
	else if (this.Format.toUpperCase()=="MMMDDYYYY")
		return (this.GetMonthName(false)+DateSeparator+pDate+DateSeparator+this.Year);	
	else if (this.Format.toUpperCase()=="MMMYYYY")
		return (this.GetMonthName(false)+DateSeparator+this.Year);			
}
Calendar.prototype.FormatDate=FormatDate;	