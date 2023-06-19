namespace SSP.Infrastructure.Utility
{
    public class TaxFormula
    {
        public static double computeformula(double basic, double rent, double trans, string type)
        {
            double output = 0;
            if (type == "NHF")
                output = ((2.5 * basic) / 100);

            if (type == "NHIS")
                output = ((5 * basic) / 100);

            if (type == "PENSION")
                output = ((8 * (basic + rent + trans)) / 100);
            return output;
        }

        public static double[] calculatetax(double annualIncome, double basic, double rent, double trans, double pension, double pensiondeclared, double nhf, double nhfdeclared, double nhis, double nhisdeclared, int no_of_months)
        {
            double finalcra = 0;
            double finalpension = 0;
            double finalnhf = 0;
            double finalnhis = 0;

            if (pension != 1)
            {
                finalpension = pensiondeclared;
            }
            else
            {
                if (pensiondeclared != 0)
                {
                    finalpension = computeformula(basic, rent, trans, "PENSION");
                }
            }

            if (nhf != 1.0)
            {
                finalnhf = nhfdeclared;
            }
            else
            {
                if (nhfdeclared != 0)
                {
                    finalnhf = computeformula(basic, rent, trans, "NHF");
                }
            }

            if (nhis != 1.0)
            {
                finalnhis = nhisdeclared;
            }
            else
            {
                if (nhisdeclared != 0)
                {
                    finalnhis = computeformula(basic, rent, trans, "NHIS");
                }
            }

            double tax_exempt = finalpension + finalnhf + finalnhis;

            double gross = annualIncome - tax_exempt;
            double cra1 = ((gross * (20)) / 100) + 200000;
            double cra2 = ((gross * (20)) / 100) + ((gross * (1)) / 100);

            if (gross > 20000000)
            {
                finalcra = cra2;
            }
            else
            {
                finalcra = cra1;
            }

            double tax_free_pay = finalcra + tax_exempt;
            double chargableincome = annualIncome - tax_free_pay;

            double annualtax = calculate_tax(chargableincome, gross);
            double monthlytax = annualtax / 12;
            annualtax = monthlytax * no_of_months; // use months to get the correct tax


            double[] charges = new double[8];
            charges[0] = Math.Round(finalcra, 2);
            charges[1] = Math.Round(finalpension, 2);
            charges[2] = Math.Round(finalnhf, 2);
            charges[3] = Math.Round(finalnhis, 2);
            charges[4] = Math.Round(tax_free_pay, 2);
            charges[5] = Math.Round(chargableincome, 2);
            charges[6] = Math.Round(annualtax, 2);
            charges[7] = Math.Round(monthlytax, 2);

            return charges;
        }

        public static double calculate_tax(double ch_income, double gross)
        {
            double calc_tax = 0;
            double min_tax = 0;
            double finaltax = 0;

            if (ch_income <= 0)
            {
                calc_tax = ((gross * 1) / 100);
            }
            else if (ch_income <= 300000)
            {
                calc_tax = (ch_income * (7)) / 100;
            }
            else if (ch_income <= 600000)
            {
                calc_tax = (((ch_income - 300000) * (11)) / 100) + 21000;
            }
            else if (ch_income <= 1100000)
            {
                calc_tax = (((ch_income - 600000) * (15)) / 100) + 54000;
            }
            else if (ch_income <= 1600000)
            {
                calc_tax = (((ch_income - 1100000) * (19)) / 100) + 129000;
            }
            else if (ch_income <= 3200000)
            {
                calc_tax = (((ch_income - 1600000) * (21)) / 100) + 224000;
            }
            else
            {
                calc_tax = (((ch_income - 3200000) * (24)) / 100) + 560000;
            }
            min_tax = (gross * (1)) / 100;

            if (calc_tax < min_tax)
            {
                finaltax = min_tax;
            }
            else
            {
                finaltax = calc_tax;
            }
            return finaltax;
        }
    }
}
