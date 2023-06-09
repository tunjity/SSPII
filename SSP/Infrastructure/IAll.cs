﻿using System.Net;
using System;
using SSP.PayeModelII;

namespace SSP.Infrastructure
{
    public interface ICompanyListApiRepository : IGenericRepository<CompanyListApi> {
        CompanyListApi GetByRIN(string rin);
    }
    public interface IAssetTaxPayerDetailsApiRepository : IGenericRepository<AssetTaxPayerDetailsApi> { }
    public interface IBusinessEmployeeRepository : IGenericRepository<BusinessEmployee> { } 
    public interface IAddPayeInputFileRepository : IGenericRepository<AddPayeInputFile> { }
    public interface IAgencyRepository : IGenericRepository<Agency> { }
    public interface IAgencyTypeRepository : IGenericRepository<AgencyType> { }
    public interface IApiJsonStrRepository : IGenericRepository<ApiJsonStr> { }
    public interface IAssessmentRepository : IGenericRepository<Assessment> { } 
    public interface IAssessmentChildRepository : IGenericRepository<AssessmentChild> { }
    public interface IAssessmentGroupRepository : IGenericRepository<AssessmentGroup> { }
    public interface IAssessmentItemRepository : IGenericRepository<AssessmentItem> { }
    public interface IAssessmentItemApiRepository : IGenericRepository<AssessmentItemApi> { }
    public interface IAssessmentItemBkApiRepository : IGenericRepository<AssessmentItemBkApi> { }
    public interface IAssessmentItemCategoryRepository : IGenericRepository<AssessmentItemCategory> { }
    public interface IAssessmentItemSubCategoryRepository : IGenericRepository<AssessmentItemSubCategory> { }
    public interface IAssessmentRuleRepository : IGenericRepository<AssessmentRule> { }
    public interface IAssessmentRule1Repository : IGenericRepository<AssessmentRule1> { }
    public interface IAssessmentRuleMasterApiRepository : IGenericRepository<AssessmentRuleMasterApi> { }
    public interface IAssessmentRulesApiRepository : IGenericRepository<AssessmentRulesApi> { }
    public interface IAssessmentsApiRepository : IGenericRepository<AssessmentsApi> { }
    public interface IAssessmentStatusRepository : IGenericRepository<AssessmentStatus> { }
    public interface IAssessmentSubGroupRepository : IGenericRepository<AssessmentSubGroup> { }
    public interface IAssetTypeRepository : IGenericRepository<AssetType> { }
    public interface IBuildingRepository : IGenericRepository<Building> { }
    public interface IBusinessRepository : IGenericRepository<Business> { }
    public interface IBusinessCategoryRepository : IGenericRepository<BusinessCategory> { }
    public interface IBusinessesApiRepository : IGenericRepository<BusinessesApi> { }
    public interface IBusinessesApiMainRepository : IGenericRepository<BusinessesApiMain> { }
   // public interface IBusinessesBkApiRepository : IGenericRepository<BusinessesBkApi> { }
    public interface IBusinessesFullApiRepository : IGenericRepository<BusinessesFullApi> { }
    public interface IBusinessOperationRepository : IGenericRepository<BusinessOperation> { }
    public interface IBusinessSectorRepository : IGenericRepository<BusinessSector> { }
    public interface IBusinessStructureRepository : IGenericRepository<BusinessStructure> { }
    public interface IBusinessSubSectorRepository : IGenericRepository<BusinessSubSector> { }
    public interface IBusinessTypeRepository : IGenericRepository<BusinessType> { }
    public interface IClearanceCertificateRepository : IGenericRepository<ClearanceCertificate> { }
    //public interface ICompaniesApiRepository : IGenericRepository<CompaniesApi> { }
    //public interface ICompanyRepository : IGenericRepository<Company> { }
    //public interface ICompanyListBkApiRepository : IGenericRepository<CompanyListBkApi> { }
    public interface IDirectorateRepository : IGenericRepository<Directorate> { }
    public interface IEconomicActivityRepository : IGenericRepository<EconomicActivity> { }
    public interface IEirsUserRepository : IGenericRepository<EirsUser> { }
    public interface IEmployeeAnnualTaxRepository : IGenericRepository<EmployeeAnnualTax> { }
    public interface IEmployeeContributionOutputFileRepository : IGenericRepository<EmployeeContributionOutputFile> { }
    public interface IEmployerAssessmentOutputFileRepository : IGenericRepository<EmployerAssessmentOutputFile> { }
    public interface IExceptionTypeRepository : IGenericRepository<ExceptionType> { }
    public interface IEmployeeRepository : IGenericRepository<Employee> { }
    public interface IFileStatusRepository : IGenericRepository<FileStatus> { }
    public interface IFormMasterRepository : IGenericRepository<FormMaster> { }
    public interface IGroupFormRelationRepository : IGenericRepository<GroupFormRelation> { }
    public interface IGroupMasterRepository : IGenericRepository<GroupMaster> { }
    public interface IIndividualRepository : IGenericRepository<Individual> { }
    public interface IIndividualsApiRepository : IGenericRepository<IndividualsApi> { }
    public interface IIndividualsApiInputRepository : IGenericRepository<IndividualsApiInput> { }
    public interface ILegacySubmissionsPayeRepository : IGenericRepository<LegacySubmissionsPaye> { }
    public interface ILocalGovernmentAreaRepository : IGenericRepository<LocalGovernmentArea> { }
    public interface IMyView1Repository : IGenericRepository<MyView1> { }
    public interface INationalityRepository : IGenericRepository<Nationality> { }
    public interface INotificationRepository : IGenericRepository<Notification> { }
    public interface INotificationMethodRepository : IGenericRepository<NotificationMethod> { }
    public interface INotificationTypeRepository : IGenericRepository<NotificationType> { }
    public interface IPayeInputFileRepository : IGenericRepository<PayeInputFile> { }
    public interface IPayeOuputFileRepository : IGenericRepository<PayeOuputFile> { }
    public interface IPayesubmissionAbhayLiveRepository : IGenericRepository<PayesubmissionAbhayLive> { }
    public interface IPaymentFrequencyRepository : IGenericRepository<PaymentFrequency> { }
    public interface IPaymentOptionRepository : IGenericRepository<PaymentOption> { }
    public interface IPreAsessmentTempRepository : IGenericRepository<PreAsessmentTemp> { }
    public interface IPreAssessmentRepository : IGenericRepository<PreAssessment> { }
    public interface IPreAssessment1Repository : IGenericRepository<PreAssessment1> { }
    public interface IPreAssessmentRdmRepository : IGenericRepository<PreAssessmentRdm> { }
    public interface IProfileRepository : IGenericRepository<Profile> { }
    public interface IProfilesApiRepository : IGenericRepository<ProfilesApi> { }
    public interface IRecordLinkRepository : IGenericRepository<RecordLink> { }
    public interface IRevenueStreamRepository : IGenericRepository<RevenueStream> { }
    public interface IRevenueSubStreamRepository : IGenericRepository<RevenueSubStream> { }
    public interface IRuleEngineRepository : IGenericRepository<RuleEngine> { }
    public interface ISalaryBreakupRepository : IGenericRepository<SalaryBreakup> { }
    public interface ISalaryTypeMasterRepository : IGenericRepository<SalaryTypeMaster> { }
    public interface ISettlementRepository : IGenericRepository<Settlement> { }
    public interface ISettlementMethodRepository : IGenericRepository<SettlementMethod> { }
    public interface ISettlementStatusRepository : IGenericRepository<SettlementStatus> { }
    public interface IStateMasterRepository : IGenericRepository<StateMaster> { }
    public interface ISubmissionRepository : IGenericRepository<Submission> { }
    public interface ISubmissionsBkpaaRepository : IGenericRepository<SubmissionsBkpaa> { }
    public interface ISubmissionsDefaultRepository : IGenericRepository<SubmissionsDefault> { }
    public interface ITablesApiUpdatedRepository : IGenericRepository<TablesApiUpdated> { }
    public interface ITaxNewYearRepository : IGenericRepository<TaxNewYear> { }
    public interface ITaxOfficeRepository : IGenericRepository<TaxOffice> { }
    public interface ITaxPayerRoleRepository : IGenericRepository<TaxPayerRole> { }
    public interface ITaxPayerTypeRepository : IGenericRepository<TaxPayerType> { }
    public interface ITitleRepository : IGenericRepository<Title> { }
    public interface ITokenManagementRepository : IGenericRepository<TokenManagement> { }
    public interface ITownRepository : IGenericRepository<Town> { }
    public interface IVwAssessIndSalRepository : IGenericRepository<VwAssessIndSal> { }
    public interface IVwAssessIndSalRefundRepository : IGenericRepository<VwAssessIndSalRefund> { }
    public interface IVwAssessmentRuleRepository : IGenericRepository<VwAssessmentRule> { }
    public interface IVwAssessmentSearchRepository : IGenericRepository<VwAssessmentSearch> { }
    public interface IVwBusinessCompRelationRepository : IGenericRepository<VwBusinessCompRelation> { }
    public interface IVwBusinessDetailRepository : IGenericRepository<VwBusinessDetail> { }
    public interface IVwClearanceCertReqRepository : IGenericRepository<VwClearanceCertReq> { }
    public interface IVwCompanyRepository : IGenericRepository<VwCompany> { }
    public interface IVwCompIndSalRepository : IGenericRepository<VwCompIndSal> { }
    public interface IVwCorporatesAssetRepository : IGenericRepository<VwCorporatesAsset> { }
    public interface IVwDistinctIndividualRepository : IGenericRepository<VwDistinctIndividual> { }
    public interface IVwEmployeeContributionOutputFileRepository : IGenericRepository<VwEmployeeContributionOutputFile> { }
    public interface IVwEmployerContributionRepository : IGenericRepository<VwEmployerContribution> { }
    public interface IVwEmployerContributionOldRepository : IGenericRepository<VwEmployerContributionOld> { }
    public interface IVwGetCollectorOutputFileRepository : IGenericRepository<VwGetCollectorOutputFile> { }
    public interface IVwGetDistinctInputFileRepository : IGenericRepository<VwGetDistinctInputFile> { }
    public interface IVwGetPreAssessmentRepository : IGenericRepository<VwGetPreAssessment> { }
    public interface IVwGetPreAssessment31Jan2020Repository : IGenericRepository<VwGetPreAssessment31Jan2020> { }
    public interface IVwIndDetailRepository : IGenericRepository<VwIndDetail> { }
    public interface IVwInputFileRepository : IGenericRepository<VwInputFile> { }
    public interface IVwInputFileMainRepository : IGenericRepository<VwInputFileMain> { }
    public interface IVwInputFileMainViewRepository : IGenericRepository<VwInputFileMainView> { }
    public interface IVwIntRepository : IGenericRepository<VwInt> { }
    public interface IVwLegacySubmissionRepository : IGenericRepository<VwLegacySubmission> { }
    public interface IVwMonthlyTaxCompanyWiseRepository : IGenericRepository<VwMonthlyTaxCompanyWise> { }
    public interface IVwMonthlyTaxEmpWiseRepository : IGenericRepository<VwMonthlyTaxEmpWise> { }
    public interface IVwPateInputFileRepository : IGenericRepository<VwPateInputFile> { }
    public interface IVwPayeInputFileRepository : IGenericRepository<VwPayeInputFile> { }
    public interface IVwPayeInputFileNRepository : IGenericRepository<VwPayeInputFileN> { }
    public interface IVwPaymentRepository : IGenericRepository<VwPayment> { }
    public interface IVwPaymentDetailRepository : IGenericRepository<VwPaymentDetail> { }
    public interface IVwPerformanceReportRepository : IGenericRepository<VwPerformanceReport> { }
    public interface IVwPreAssessmentRdmRepository : IGenericRepository<VwPreAssessmentRdm> { }
    public interface IVwRefundCase1Repository : IGenericRepository<VwRefundCase1> { }
    public interface IVwRulesCheckRepository : IGenericRepository<VwRulesCheck> { }
    public interface IVwRulesCheck1Repository : IGenericRepository<VwRulesCheck1> { }
    public interface IVwRulesCheck11Repository : IGenericRepository<VwRulesCheck11> { }
    public interface IVwRulesCheckOldRepository : IGenericRepository<VwRulesCheckOld> { }
    public interface IVwSalBkupAfterJoinCaseRepository : IGenericRepository<VwSalBkupAfterJoinCase> { }
    public interface IVwSalBkupIncrementCaseRepository : IGenericRepository<VwSalBkupIncrementCase> { }
    public interface IVwSettlementRepository : IGenericRepository<VwSettlement> { }
    public interface IVwSettlementReportRepository : IGenericRepository<VwSettlementReport> { }
    public interface IVwShowBusinessRepository : IGenericRepository<VwSettlementReport2> { }
    public interface IVwShowBusinessPayeInputFileRepository : IGenericRepository<VwShowBusinessPayeInputFile> { }
    public interface IVwShowBusinessPayeInputFileAllRepository : IGenericRepository<VwShowBusinessPayeInputFileAll> { }
    public interface IVwShowBusinessPayeInputFileAll1Repository : IGenericRepository<VwShowBusinessPayeInputFileAll1> { }
    public interface IVwShowBusinessPayeInputFileAll2Repository : IGenericRepository<VwShowBusinessPayeInputFileAll2> { }
    public interface IVwShowBusinessPayeInputFileAllARepository : IGenericRepository<VwShowBusinessPayeInputFileAllA> { }
    public interface IVwShowBusinessPayeInputFileAllSelectedRepository : IGenericRepository<VwShowBusinessPayeInputFileAllSelected> { }
    public interface IVwSubmissionRepository : IGenericRepository<VwSubmission> { }
    public interface IVwSubmissions1Repository : IGenericRepository<VwSubmissions1> { }
    public interface IVwSubmissionViewRepository : IGenericRepository<VwSubmissionView> { }
    public interface IVwSubmissionViewOtherMonthRepository : IGenericRepository<VwSubmissionViewOtherMonth> { }
    public interface IVwTaxAnalysisRepository : IGenericRepository<VwTaxAnalysis> { }
    public interface IVwTaxAnalysis24Oct2019Repository : IGenericRepository<VwTaxAnalysis24Oct2019> { }
    public interface IVwTaxbaseComputationFinalRepository : IGenericRepository<VwTaxbaseComputationFinal> { }
    public interface IVwTaxComputationRepository : IGenericRepository<VwTaxComputation> { }
    public interface IVwTaxComputationEmployerCollectionRepository : IGenericRepository<VwTaxComputationEmployerCollection> { }
    public interface IVwTaxComputationFinalRepository : IGenericRepository<VwTaxComputationFinal> { }
    public interface IVwTestKaushikViewRepository : IGenericRepository<VwTestKaushikView> { }
    public interface IWardRepository : IGenericRepository<Ward> { }
    public interface IWinastAutoEmailDetailRepository : IGenericRepository<WinastAutoEmailDetail> { }
    public interface IWinastAutoSmsDetailRepository : IGenericRepository<WinastAutoSmsDetail> { }




    public interface IUserManagementRepository : IGenericRepository<UserManagement> { }
  //  public interface IBusinessEmployeeRepository : IGenericRepository<BusinessEmployee> { }
    public interface IEmployeesMonthlyIncomeRepository : IGenericRepository<EmployeesMonthlyIncome> { }
    public interface IEmployeesMonthlyScheduleRepository : IGenericRepository<EmployeesMonthlySchedule> { }
    public interface ISchedule_CommentRepository : IGenericRepository<ScheduleComment> { }
    public interface IScheduleStatusRepository : IGenericRepository<ScheduleStatus> { }


}
