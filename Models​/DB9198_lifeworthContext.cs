using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LifeworthAPI.Models​
{
    public partial class DB9198_lifeworthContext : DbContext
    {
        public DB9198_lifeworthContext()
        {
        }

        public DB9198_lifeworthContext(DbContextOptions<DB9198_lifeworthContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountDetail> AccountDetail { get; set; }
        public virtual DbSet<AccountMaster> AccountMaster { get; set; }
        public virtual DbSet<AdditionalCover> AdditionalCover { get; set; }
        public virtual DbSet<Adeolaformno> Adeolaformno { get; set; }
        public virtual DbSet<Agency> Agency { get; set; }
        public virtual DbSet<AgencyZone> AgencyZone { get; set; }
        public virtual DbSet<AgentType> AgentType { get; set; }
        public virtual DbSet<Agents> Agents { get; set; }
        public virtual DbSet<AreaOfSpecialty> AreaOfSpecialty { get; set; }
        public virtual DbSet<Attendance> Attendance { get; set; }
        public virtual DbSet<Attendance2> Attendance2 { get; set; }
        public virtual DbSet<AuditCoy> AuditCoy { get; set; }
        public virtual DbSet<AuditE> AuditE { get; set; }
        public virtual DbSet<AuditP> AuditP { get; set; }
        public virtual DbSet<AuditPcp> AuditPcp { get; set; }
        public virtual DbSet<Audittrail> Audittrail { get; set; }
        public virtual DbSet<AudittrailCoy> AudittrailCoy { get; set; }
        public virtual DbSet<AudittrailE> AudittrailE { get; set; }
        public virtual DbSet<AudittrailPcp> AudittrailPcp { get; set; }
        public virtual DbSet<Authcode> Authcode { get; set; }
        public virtual DbSet<AuthcodeN> AuthcodeN { get; set; }
        public virtual DbSet<AuthcodeTrans> AuthcodeTrans { get; set; }
        public virtual DbSet<AuthcodeTransN> AuthcodeTransN { get; set; }
        public virtual DbSet<AuthorisationTb> AuthorisationTb { get; set; }
        public virtual DbSet<AuthorizerTb> AuthorizerTb { get; set; }
        public virtual DbSet<Authview> Authview { get; set; }
        public virtual DbSet<Authview2> Authview2 { get; set; }
        public virtual DbSet<Authview2a> Authview2a { get; set; }
        public virtual DbSet<Authviewa> Authviewa { get; set; }
        public virtual DbSet<Authviewdep> Authviewdep { get; set; }
        public virtual DbSet<Authviewemp> Authviewemp { get; set; }
        public virtual DbSet<AutoNumber> AutoNumber { get; set; }
        public virtual DbSet<BandATbl> BandATbl { get; set; }
        public virtual DbSet<BandATbl2> BandATbl2 { get; set; }
        public virtual DbSet<BandBTbl> BandBTbl { get; set; }
        public virtual DbSet<BandCTbl> BandCTbl { get; set; }
        public virtual DbSet<BandDTbl> BandDTbl { get; set; }
        public virtual DbSet<BandGTbl> BandGTbl { get; set; }
        public virtual DbSet<BandSp1Tbl> BandSp1Tbl { get; set; }
        public virtual DbSet<BandSp2Tbl> BandSp2Tbl { get; set; }
        public virtual DbSet<BandTb> BandTb { get; set; }
        public virtual DbSet<Banda> Banda { get; set; }
        public virtual DbSet<BankCodeTb> BankCodeTb { get; set; }
        public virtual DbSet<BankTb> BankTb { get; set; }
        public virtual DbSet<BenefitView> BenefitView { get; set; }
        public virtual DbSet<Birthdates> Birthdates { get; set; }
        public virtual DbSet<Bkadeola> Bkadeola { get; set; }
        public virtual DbSet<Bkbanda> Bkbanda { get; set; }
        public virtual DbSet<Bkbandb2> Bkbandb2 { get; set; }
        public virtual DbSet<Bkbandsp2> Bkbandsp2 { get; set; }
        public virtual DbSet<Bksumadeola> Bksumadeola { get; set; }
        public virtual DbSet<BloodGroupTb> BloodGroupTb { get; set; }
        public virtual DbSet<CapReport> CapReport { get; set; }
        public virtual DbSet<CapView1> CapView1 { get; set; }
        public virtual DbSet<CapView2> CapView2 { get; set; }
        public virtual DbSet<Capitation> Capitation { get; set; }
        public virtual DbSet<CapitationHistory> CapitationHistory { get; set; }
        public virtual DbSet<CapitationSumRpt> CapitationSumRpt { get; set; }
        public virtual DbSet<CapitationX> CapitationX { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<ChangeProvider> ChangeProvider { get; set; }
        public virtual DbSet<Changeprovider2> Changeprovider2 { get; set; }
        public virtual DbSet<ChangprovView> ChangprovView { get; set; }
        public virtual DbSet<Cheque> Cheque { get; set; }
        public virtual DbSet<ClaimDiagnosis> ClaimDiagnosis { get; set; }
        public virtual DbSet<ClaimTreatments> ClaimTreatments { get; set; }
        public virtual DbSet<Claims> Claims { get; set; }
        public virtual DbSet<ClaimsMtb> ClaimsMtb { get; set; }
        public virtual DbSet<ClaimsMtbDetail> ClaimsMtbDetail { get; set; }
        public virtual DbSet<ClaimsMtbDetailN> ClaimsMtbDetailN { get; set; }
        public virtual DbSet<ClaimsMtbn> ClaimsMtbn { get; set; }
        public virtual DbSet<ClaimsNotes> ClaimsNotes { get; set; }
        public virtual DbSet<Classification> Classification { get; set; }
        public virtual DbSet<Classify> Classify { get; set; }
        public virtual DbSet<ClientOfficer> ClientOfficer { get; set; }
        public virtual DbSet<CommentEnr> CommentEnr { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<Comments2> Comments2 { get; set; }
        public virtual DbSet<Comments3> Comments3 { get; set; }
        public virtual DbSet<Commission> Commission { get; set; }
        public virtual DbSet<Commissions> Commissions { get; set; }
        public virtual DbSet<CompPayAmtD> CompPayAmtD { get; set; }
        public virtual DbSet<CompPayBillD> CompPayBillD { get; set; }
        public virtual DbSet<CompPayMaster> CompPayMaster { get; set; }
        public virtual DbSet<CompPayment> CompPayment { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<CompanyO> CompanyO { get; set; }
        public virtual DbSet<ComplainEndResult> ComplainEndResult { get; set; }
        public virtual DbSet<ComplainTypes> ComplainTypes { get; set; }
        public virtual DbSet<Complains> Complains { get; set; }
        public virtual DbSet<CorpBenefits> CorpBenefits { get; set; }
        public virtual DbSet<CountAll> CountAll { get; set; }
        public virtual DbSet<CountdepAll> CountdepAll { get; set; }
        public virtual DbSet<CountryCodeTb> CountryCodeTb { get; set; }
        public virtual DbSet<CoverTbl> CoverTbl { get; set; }
        public virtual DbSet<Covertype> Covertype { get; set; }
        public virtual DbSet<CoyLogin> CoyLogin { get; set; }
        public virtual DbSet<CoyPortal> CoyPortal { get; set; }
        public virtual DbSet<Coypol> Coypol { get; set; }
        public virtual DbSet<CrNoteDetail> CrNoteDetail { get; set; }
        public virtual DbSet<CrNoteMaster> CrNoteMaster { get; set; }
        public virtual DbSet<Crmview> Crmview { get; set; }
        public virtual DbSet<Delta> Delta { get; set; }
        public virtual DbSet<DeltaDesignation> DeltaDesignation { get; set; }
        public virtual DbSet<DeltaEmployeeNo> DeltaEmployeeNo { get; set; }
        public virtual DbSet<DeltaPolicy> DeltaPolicy { get; set; }
        public virtual DbSet<DeltaProduct> DeltaProduct { get; set; }
        public virtual DbSet<DeltaProvider> DeltaProvider { get; set; }
        public virtual DbSet<DeltaResons> DeltaResons { get; set; }
        public virtual DbSet<DeltaType> DeltaType { get; set; }
        public virtual DbSet<DepSbu> DepSbu { get; set; }
        public virtual DbSet<Depcount> Depcount { get; set; }
        public virtual DbSet<Depcountcoy> Depcountcoy { get; set; }
        public virtual DbSet<Depcrm> Depcrm { get; set; }
        public virtual DbSet<Depct> Depct { get; set; }
        public virtual DbSet<Dependant> Dependant { get; set; }
        public virtual DbSet<Dependant55> Dependant55 { get; set; }
        public virtual DbSet<DependantHistory> DependantHistory { get; set; }
        public virtual DbSet<DependantO> DependantO { get; set; }
        public virtual DbSet<Deppoldetails> Deppoldetails { get; set; }
        public virtual DbSet<Designation> Designation { get; set; }
        public virtual DbSet<DiagnosisList> DiagnosisList { get; set; }
        public virtual DbSet<DifferenceReason> DifferenceReason { get; set; }
        public virtual DbSet<DoctorInfoTb> DoctorInfoTb { get; set; }
        public virtual DbSet<DrugTb> DrugTb { get; set; }
        public virtual DbSet<EclaimsMtb> EclaimsMtb { get; set; }
        public virtual DbSet<EclaimsMtbDetail> EclaimsMtbDetail { get; set; }
        public virtual DbSet<EmpDepList> EmpDepList { get; set; }
        public virtual DbSet<EmpDepList2> EmpDepList2 { get; set; }
        public virtual DbSet<Empcount> Empcount { get; set; }
        public virtual DbSet<Empcountcoy> Empcountcoy { get; set; }
        public virtual DbSet<Empct> Empct { get; set; }
        public virtual DbSet<Emphist> Emphist { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Employee5> Employee5 { get; set; }
        public virtual DbSet<Employee55> Employee55 { get; set; }
        public virtual DbSet<EmployeeE> EmployeeE { get; set; }
        public virtual DbSet<EmployeeHistory> EmployeeHistory { get; set; }
        public virtual DbSet<EmployeeO> EmployeeO { get; set; }
        public virtual DbSet<EmployeeSickness> EmployeeSickness { get; set; }
        public virtual DbSet<Employeebk> Employeebk { get; set; }
        public virtual DbSet<Emppoldetails> Emppoldetails { get; set; }
        public virtual DbSet<EndorseTbl> EndorseTbl { get; set; }
        public virtual DbSet<Enollementlist> Enollementlist { get; set; }
        public virtual DbSet<EnrolleeLogin> EnrolleeLogin { get; set; }
        public virtual DbSet<EnrolleePortal> EnrolleePortal { get; set; }
        public virtual DbSet<ErrLogDetails> ErrLogDetails { get; set; }
        public virtual DbSet<ErrLogMaster> ErrLogMaster { get; set; }
        public virtual DbSet<FeedBack> FeedBack { get; set; }
        public virtual DbSet<FeedBackProvider> FeedBackProvider { get; set; }
        public virtual DbSet<FirstCapRun> FirstCapRun { get; set; }
        public virtual DbSet<GeneralTb> GeneralTb { get; set; }
        public virtual DbSet<GenotypeCodeTb> GenotypeCodeTb { get; set; }
        public virtual DbSet<Idcard> Idcard { get; set; }
        public virtual DbSet<Idcard1> Idcard1 { get; set; }
        public virtual DbSet<IdcardRpt> IdcardRpt { get; set; }
        public virtual DbSet<IndBenefits> IndBenefits { get; set; }
        public virtual DbSet<Insured> Insured { get; set; }
        public virtual DbSet<InsuredProvider> InsuredProvider { get; set; }
        public virtual DbSet<InvestigationTb> InvestigationTb { get; set; }
        public virtual DbSet<Jobposition> Jobposition { get; set; }
        public virtual DbSet<Lgarea> Lgarea { get; set; }
        public virtual DbSet<Limitband> Limitband { get; set; }
        public virtual DbSet<LocationTb> LocationTb { get; set; }
        public virtual DbSet<Logging> Logging { get; set; }
        public virtual DbSet<LoginTb> LoginTb { get; set; }
        public virtual DbSet<Mailconnection> Mailconnection { get; set; }
        public virtual DbSet<Mailsetup> Mailsetup { get; set; }
        public virtual DbSet<MaritalStatusCodeTb> MaritalStatusCodeTb { get; set; }
        public virtual DbSet<NewDiagnosis> NewDiagnosis { get; set; }
        public virtual DbSet<NewDiagnosis5> NewDiagnosis5 { get; set; }
        public virtual DbSet<NhisAttendance> NhisAttendance { get; set; }
        public virtual DbSet<NhisClaimsTb> NhisClaimsTb { get; set; }
        public virtual DbSet<NhisDetail> NhisDetail { get; set; }
        public virtual DbSet<NhisHospD> NhisHospD { get; set; }
        public virtual DbSet<NhisHospSum> NhisHospSum { get; set; }
        public virtual DbSet<Nhisclient> Nhisclient { get; set; }
        public virtual DbSet<Nhissum> Nhissum { get; set; }
        public virtual DbSet<Notification> Notification { get; set; }
        public virtual DbSet<Notification2> Notification2 { get; set; }
        public virtual DbSet<Notification3> Notification3 { get; set; }
        public virtual DbSet<Notification6> Notification6 { get; set; }
        public virtual DbSet<Numbercheck> Numbercheck { get; set; }
        public virtual DbSet<Occupation> Occupation { get; set; }
        public virtual DbSet<PaymentModeTb> PaymentModeTb { get; set; }
        public virtual DbSet<Pcphist> Pcphist { get; set; }
        public virtual DbSet<PersonsBackup> PersonsBackup { get; set; }
        public virtual DbSet<PlanCategoryTb> PlanCategoryTb { get; set; }
        public virtual DbSet<PlanType1Tb> PlanType1Tb { get; set; }
        public virtual DbSet<Policy> Policy { get; set; }
        public virtual DbSet<PolicyReschd> PolicyReschd { get; set; }
        public virtual DbSet<PolicyUpdDetails> PolicyUpdDetails { get; set; }
        public virtual DbSet<PolicyUpdMaster> PolicyUpdMaster { get; set; }
        public virtual DbSet<PrdBenefits> PrdBenefits { get; set; }
        public virtual DbSet<PreEmployDetail> PreEmployDetail { get; set; }
        public virtual DbSet<PreEmployMaster> PreEmployMaster { get; set; }
        public virtual DbSet<Preferences> Preferences { get; set; }
        public virtual DbSet<Premium> Premium { get; set; }
        public virtual DbSet<PremiumDetail> PremiumDetail { get; set; }
        public virtual DbSet<PremiumHistory> PremiumHistory { get; set; }
        public virtual DbSet<PretestMtb> PretestMtb { get; set; }
        public virtual DbSet<PretestMtbDetail> PretestMtbDetail { get; set; }
        public virtual DbSet<PrivateSchemeImport> PrivateSchemeImport { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProspectiveProduct> ProspectiveProduct { get; set; }
        public virtual DbSet<Provider> Provider { get; set; }
        public virtual DbSet<Provider1> Provider1 { get; set; }
        public virtual DbSet<ProviderLogin> ProviderLogin { get; set; }
        public virtual DbSet<ProviderPortal> ProviderPortal { get; set; }
        public virtual DbSet<ProviderPp> ProviderPp { get; set; }
        public virtual DbSet<ProviderReturns> ProviderReturns { get; set; }
        public virtual DbSet<ProviderReturnsMaster> ProviderReturnsMaster { get; set; }
        public virtual DbSet<ProviderScp> ProviderScp { get; set; }
        public virtual DbSet<ProviderSpecialty> ProviderSpecialty { get; set; }
        public virtual DbSet<Providernhis> Providernhis { get; set; }
        public virtual DbSet<Provlist> Provlist { get; set; }
        public virtual DbSet<Query> Query { get; set; }
        public virtual DbSet<Reasons> Reasons { get; set; }
        public virtual DbSet<ReferralReason> ReferralReason { get; set; }
        public virtual DbSet<Referrals> Referrals { get; set; }
        public virtual DbSet<Reimburse> Reimburse { get; set; }
        public virtual DbSet<ReimburseMtb> ReimburseMtb { get; set; }
        public virtual DbSet<ReimburseMtbDetail> ReimburseMtbDetail { get; set; }
        public virtual DbSet<Reimbursetb> Reimbursetb { get; set; }
        public virtual DbSet<RelationshipTb> RelationshipTb { get; set; }
        public virtual DbSet<ReligionTb> ReligionTb { get; set; }
        public virtual DbSet<RequisitionDetails> RequisitionDetails { get; set; }
        public virtual DbSet<RequisitionMaster> RequisitionMaster { get; set; }
        public virtual DbSet<RptAttRatio> RptAttRatio { get; set; }
        public virtual DbSet<RptAuthcodeTrans> RptAuthcodeTrans { get; set; }
        public virtual DbSet<RptCap> RptCap { get; set; }
        public virtual DbSet<RptClaimsAtt> RptClaimsAtt { get; set; }
        public virtual DbSet<RptNhisHospSum> RptNhisHospSum { get; set; }
        public virtual DbSet<RptNhisdetails> RptNhisdetails { get; set; }
        public virtual DbSet<RptNhissum> RptNhissum { get; set; }
        public virtual DbSet<RptReceipt> RptReceipt { get; set; }
        public virtual DbSet<Rptauth> Rptauth { get; set; }
        public virtual DbSet<Rptcapitation> Rptcapitation { get; set; }
        public virtual DbSet<RptclaimsMtb> RptclaimsMtb { get; set; }
        public virtual DbSet<Rptempcoylist> Rptempcoylist { get; set; }
        public virtual DbSet<Rptempprovcap> Rptempprovcap { get; set; }
        public virtual DbSet<Rptempprovlist> Rptempprovlist { get; set; }
        public virtual DbSet<Rptexpiring> Rptexpiring { get; set; }
        public virtual DbSet<Rptinvoice> Rptinvoice { get; set; }
        public virtual DbSet<Rptnhisclient> Rptnhisclient { get; set; }
        public virtual DbSet<SbuTb> SbuTb { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<Scphist> Scphist { get; set; }
        public virtual DbSet<Setss> Setss { get; set; }
        public virtual DbSet<Setupimg> Setupimg { get; set; }
        public virtual DbSet<SexTb> SexTb { get; set; }
        public virtual DbSet<Sickness> Sickness { get; set; }
        public virtual DbSet<Smsconfig> Smsconfig { get; set; }
        public virtual DbSet<Specialty> Specialty { get; set; }
        public virtual DbSet<StaffLevelTb> StaffLevelTb { get; set; }
        public virtual DbSet<States> States { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<TblAccounthead> TblAccounthead { get; set; }
        public virtual DbSet<TblAccounthead2> TblAccounthead2 { get; set; }
        public virtual DbSet<TblCompanyHead> TblCompanyHead { get; set; }
        public virtual DbSet<TblCompanyHead2> TblCompanyHead2 { get; set; }
        public virtual DbSet<TblHrhead> TblHrhead { get; set; }
        public virtual DbSet<TblHrhead2> TblHrhead2 { get; set; }
        public virtual DbSet<TblProviderHead> TblProviderHead { get; set; }
        public virtual DbSet<TerminatedCases> TerminatedCases { get; set; }
        public virtual DbSet<TreatmentClass> TreatmentClass { get; set; }
        public virtual DbSet<TreatmentList> TreatmentList { get; set; }
        public virtual DbSet<TreatmentResult> TreatmentResult { get; set; }
        public virtual DbSet<ViewDepSbu> ViewDepSbu { get; set; }
        public virtual DbSet<ViewEnrDepSbu> ViewEnrDepSbu { get; set; }
        public virtual DbSet<ViewEnrSbu> ViewEnrSbu { get; set; }
        public virtual DbSet<ViewSbuDetails> ViewSbuDetails { get; set; }
        public virtual DbSet<VoucherNo> VoucherNo { get; set; }
        public virtual DbSet<WardTbl> WardTbl { get; set; }
        public virtual DbSet<Xxx> Xxx { get; set; }
        public virtual DbSet<Xyz> Xyz { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-QQCN68C\\MSSQLSERVER01;Initial Catalog=DB9198_lifeworth;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountDetail>(entity =>
            {
                entity.HasKey(e => e.IdAcctDetail);

                entity.Property(e => e.IdAcctDetail).HasColumnName("Id_AcctDetail");

                entity.Property(e => e.AgentCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ChqNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ComsnPayable).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ComsnRate).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CrNoteAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DebitAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IdAcctMaster).HasColumnName("Id_AcctMaster");

                entity.Property(e => e.Narration)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PremiumId).HasColumnName("PremiumID");

                entity.Property(e => e.ReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.SettledAmt).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdAcctMasterNavigation)
                    .WithMany(p => p.AccountDetail)
                    .HasForeignKey(d => d.IdAcctMaster)
                    .HasConstraintName("FK_AccountDetail_AccountMaster1");
            });

            modelBuilder.Entity<AccountMaster>(entity =>
            {
                entity.HasKey(e => e.IdAcctMaster);

                entity.Property(e => e.IdAcctMaster).HasColumnName("Id_AcctMaster");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ChqInvNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("Id_company");

                entity.Property(e => e.Narration)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NewBalance).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PreEmployAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PremiumAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReceiptDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AdditionalCover>(entity =>
            {
                entity.HasKey(e => e.IdCover);

                entity.Property(e => e.IdCover).HasColumnName("ID_Cover");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CoverLimit).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdBenefit)
                    .HasColumnName("ID_Benefit")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IdProduct)
                    .HasColumnName("ID_Product")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Narration)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Adeolaformno>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("adeolaformno");

                entity.Property(e => e.Newformno)
                    .HasColumnName("newformno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Oldformno)
                    .HasColumnName("oldformno")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Agency>(entity =>
            {
                entity.HasIndex(e => e.AgencyCode)
                    .HasName("KeyAgc:AgencyCode")
                    .IsUnique();

                entity.Property(e => e.AgencyId)
                    .HasColumnName("AgencyID")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Address01)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address02)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgencyCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgencyName)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.BankCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.BankGlactno)
                    .HasColumnName("BankGLACTNO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FyTarget)
                    .HasColumnName("FY_Target")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IdZone)
                    .HasColumnName("ID_Zone")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Management)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RnTarget)
                    .HasColumnName("RN_Target")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StateId)
                    .HasColumnName("StateID")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdZoneNavigation)
                    .WithMany(p => p.Agency)
                    .HasForeignKey(d => d.IdZone)
                    .HasConstraintName("FK_Agency_AgencyZone");
            });

            modelBuilder.Entity<AgencyZone>(entity =>
            {
                entity.HasKey(e => e.IdZone);

                entity.HasIndex(e => e.ZoneName)
                    .HasName("Key_AgencyZone")
                    .IsUnique();

                entity.Property(e => e.IdZone)
                    .HasColumnName("ID_Zone")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AgentType>(entity =>
            {
                entity.HasKey(e => e.IdAgentType);

                entity.Property(e => e.IdAgentType)
                    .HasColumnName("ID_AgentType")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CommsnRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CorpRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IndRate).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<Agents>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Address01)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address02)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgentCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgreedCommsn).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Comments)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateEmployed).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnName("dob")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GlcomsnAcctNo)
                    .HasColumnName("GLComsnAcctNo")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.IdAgent)
                    .HasColumnName("ID_Agent")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdAgenttype)
                    .HasColumnName("ID_agenttype")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IdState)
                    .HasColumnName("ID_State")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Kin)
                    .HasColumnName("kin")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Kinadd)
                    .HasColumnName("kinadd")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Kinphone)
                    .HasColumnName("kinphone")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Mstatus)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AreaOfSpecialty>(entity =>
            {
                entity.HasKey(e => e.IdAreaOfSpecialty);

                entity.Property(e => e.IdAreaOfSpecialty).HasColumnName("ID_AreaOfSpecialty");

                entity.Property(e => e.AreaOfSpecialty1)
                    .HasColumnName("AreaOfSpecialty")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Attendance>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AttId)
                    .HasColumnName("Att_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Company).HasMaxLength(50);

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(50);

                entity.Property(e => e.Diagnosis).IsUnicode(false);

                entity.Property(e => e.Drugs).IsUnicode(false);

                entity.Property(e => e.EmployeeName).HasMaxLength(50);

                entity.Property(e => e.EmployeeNo).HasMaxLength(50);

                entity.Property(e => e.FormCode)
                    .HasColumnName("Form_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.Investigation).IsUnicode(false);

                entity.Property(e => e.Provider).HasMaxLength(50);

                entity.Property(e => e.ProviderId)
                    .HasColumnName("Provider_Id")
                    .HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(150);

                entity.Property(e => e.TransDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Attendance2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AttId)
                    .HasColumnName("Att_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasMaxLength(50);

                entity.Property(e => e.Diagnosis).IsUnicode(false);

                entity.Property(e => e.Drugs).IsUnicode(false);

                entity.Property(e => e.EmployeeNo).HasMaxLength(50);

                entity.Property(e => e.FormCode)
                    .HasColumnName("Form_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.Investigation).IsUnicode(false);

                entity.Property(e => e.ProviderId)
                    .HasColumnName("Provider_Id")
                    .HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(150);

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.Treatment).IsUnicode(false);
            });

            modelBuilder.Entity<AuditCoy>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("auditCOY");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.LocalDateTime).HasColumnType("datetime");

                entity.Property(e => e.Sn).HasColumnName("sn");

                entity.Property(e => e.Task).IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AuditE>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("auditE");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.LocalDateTime).HasColumnType("datetime");

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Task).IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AuditP>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("auditP");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DateTime)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.LocalDateTime).HasColumnType("datetime");

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Task).IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AuditPcp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("auditPCP");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.LocalDateTime).HasColumnType("datetime");

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Task).IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Audittrail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Ldate).HasColumnType("date");

                entity.Property(e => e.Ltime)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Task)
                    .HasColumnName("task")
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AudittrailCoy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AudittrailCOY");

                entity.Property(e => e.Ldate).HasColumnType("date");

                entity.Property(e => e.Ltime).HasColumnType("datetime");

                entity.Property(e => e.Sn).HasColumnName("sn");

                entity.Property(e => e.Task)
                    .HasColumnName("task")
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AudittrailE>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Ldate).HasColumnType("date");

                entity.Property(e => e.Ltime).HasColumnType("datetime");

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Task)
                    .HasColumnName("task")
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AudittrailPcp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AudittrailPCP");

                entity.Property(e => e.Ldate).HasColumnType("date");

                entity.Property(e => e.Ltime).HasColumnType("datetime");

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Task)
                    .HasColumnName("task")
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Authcode>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.LastCode).HasMaxLength(30);

                entity.Property(e => e.NewCode).HasMaxLength(30);
            });

            modelBuilder.Entity<AuthcodeN>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.LastCode).HasMaxLength(30);

                entity.Property(e => e.NewCode).HasMaxLength(30);
            });

            modelBuilder.Entity<AuthcodeTrans>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuthBy).HasMaxLength(50);

                entity.Property(e => e.Authcode)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Claim)
                    .HasColumnName("claim")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Diagnosis).IsUnicode(false);

                entity.Property(e => e.Employeeid).HasMaxLength(20);

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.Provtype)
                    .HasColumnName("provtype")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasMaxLength(30);
            });

            modelBuilder.Entity<AuthcodeTransN>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuthBy).HasMaxLength(50);

                entity.Property(e => e.Authcode)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Claim)
                    .HasColumnName("claim")
                    .HasMaxLength(1);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Employeeid).HasMaxLength(20);

                entity.Property(e => e.IdProvider)
                    .HasColumnName("ID_Provider")
                    .HasMaxLength(10);

                entity.Property(e => e.UserId).HasMaxLength(20);
            });

            modelBuilder.Entity<AuthorisationTb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AuthorisationTB");

                entity.Property(e => e.Age).HasColumnName("AGE");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Date1).HasColumnType("datetime");

                entity.Property(e => e.DependantNo)
                    .HasColumnName("DEPENDANT NO")
                    .HasMaxLength(20);

                entity.Property(e => e.DrName)
                    .IsRequired()
                    .HasColumnName("DR NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.MhsNo)
                    .HasColumnName("Mhs No")
                    .HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PatientName)
                    .IsRequired()
                    .HasColumnName("PATIENT NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientNumber)
                    .IsRequired()
                    .HasColumnName("PATIENT_NUMBER")
                    .HasMaxLength(20);

                entity.Property(e => e.ProvisionalDiagnosis)
                    .HasColumnName("Provisional Diagnosis")
                    .HasMaxLength(250);

                entity.Property(e => e.Sex)
                    .HasColumnName("SEX")
                    .HasMaxLength(2);

                entity.Property(e => e.Summary).HasColumnType("ntext");

                entity.Property(e => e.TimeIn)
                    .HasColumnName("Time in")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpsizeTs)
                    .IsRequired()
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<AuthorizerTb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AuthorizerTB");

                entity.Property(e => e.Code).HasMaxLength(30);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Authview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("authview");

                entity.Property(e => e.Claim)
                    .HasColumnName("claim")
                    .HasMaxLength(1);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Diagnosis).IsUnicode(false);

                entity.Property(e => e.Employeeid).HasMaxLength(20);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Provtype)
                    .HasColumnName("provtype")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Authview2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("authview2");

                entity.Property(e => e.Claim)
                    .HasColumnName("claim")
                    .HasMaxLength(1);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Diagnosis).IsUnicode(false);

                entity.Property(e => e.Employeeid).HasMaxLength(20);

                entity.Property(e => e.Name)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Provtype)
                    .HasColumnName("provtype")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Authview2a>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("authview2a");

                entity.Property(e => e.Claim)
                    .HasColumnName("claim")
                    .HasMaxLength(1);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Diagnosis).IsUnicode(false);

                entity.Property(e => e.Employeeid).HasMaxLength(20);

                entity.Property(e => e.Name)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Provtype)
                    .HasColumnName("provtype")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Authviewa>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("authviewa");

                entity.Property(e => e.Claim)
                    .HasColumnName("claim")
                    .HasMaxLength(1);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Diagnosis).IsUnicode(false);

                entity.Property(e => e.Employeeid).HasMaxLength(20);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Provtype)
                    .HasColumnName("provtype")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Authviewdep>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("authviewdep");

                entity.Property(e => e.Claim)
                    .HasColumnName("claim")
                    .HasMaxLength(1);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Diagnosis).IsUnicode(false);

                entity.Property(e => e.Employeeid).HasMaxLength(20);

                entity.Property(e => e.Name)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Provtype)
                    .HasColumnName("provtype")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Authviewemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("authviewemp");

                entity.Property(e => e.Claim)
                    .HasColumnName("claim")
                    .HasMaxLength(1);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Diagnosis).IsUnicode(false);

                entity.Property(e => e.Employeeid).HasMaxLength(20);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Provtype)
                    .HasColumnName("provtype")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AutoNumber>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<BandATbl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BandA_tbl");

                entity.Property(e => e.Classification)
                    .HasColumnName("classification")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Refer)
                    .HasColumnName("refer")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Unit)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BandATbl2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BandA_tbl2");

                entity.Property(e => e.Classification)
                    .HasColumnName("classification")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Refer)
                    .HasColumnName("refer")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Unit)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BandBTbl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BandB_tbl");

                entity.Property(e => e.Classification)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BandCTbl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BandC_tbl");

                entity.Property(e => e.Classification)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BandDTbl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BandD_tbl");

                entity.Property(e => e.Classification)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BandGTbl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BandG_tbl");

                entity.Property(e => e.Classification)
                    .HasColumnName("classification")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Refer)
                    .HasColumnName("refer")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Unit)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BandSp1Tbl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BandSP1_tbl");

                entity.Property(e => e.Classification)
                    .HasColumnName("CLASSIFICATION")
                    .HasMaxLength(255);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Unit)
                    .HasColumnName("UNIT")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<BandSp2Tbl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BandSP2_tbl");

                entity.Property(e => e.Classification)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Unit)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BandTb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bandTB");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Banda>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BANDA");

                entity.Property(e => e.Classification)
                    .HasColumnName("classification")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Refer)
                    .HasColumnName("refer")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Unit)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BankCodeTb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BankCodeTB");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(3);

                entity.Property(e => e.Description).HasMaxLength(50);
            });

            modelBuilder.Entity<BankTb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BankTB");

                entity.Property(e => e.BankAddress)
                    .HasColumnName("BANK_ADDRESS")
                    .HasMaxLength(30);

                entity.Property(e => e.BankCity)
                    .HasColumnName("BANK_CITY")
                    .HasMaxLength(15);

                entity.Property(e => e.BankCode)
                    .IsRequired()
                    .HasColumnName("BANK_CODE")
                    .HasMaxLength(20);

                entity.Property(e => e.BankCountry)
                    .HasColumnName("BANK_COUNTRY")
                    .HasMaxLength(15);

                entity.Property(e => e.BankEMail)
                    .HasColumnName("BANK_E-MAIL")
                    .HasMaxLength(20);

                entity.Property(e => e.BankFax)
                    .HasColumnName("BANK_FAX")
                    .HasMaxLength(15);

                entity.Property(e => e.BankName)
                    .HasColumnName("BANK_NAME")
                    .HasMaxLength(30);

                entity.Property(e => e.BankPhone)
                    .HasColumnName("BANK_PHONE")
                    .HasMaxLength(20);

                entity.Property(e => e.BankState)
                    .HasColumnName("BANK_STATE")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchCode)
                    .HasColumnName("BRANCH_CODE")
                    .HasMaxLength(15);

                entity.Property(e => e.BranchDescription)
                    .HasColumnName("BRANCH_DESCRIPTION")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<BenefitView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BenefitView");

                entity.Property(e => e.IdBenefit).HasColumnName("ID_Benefit");

                entity.Property(e => e.IdProduct)
                    .IsRequired()
                    .HasColumnName("ID_Product")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PrdBenefit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Birthdates>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DateOfBrith).HasColumnType("date");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fullname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bkadeola>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bkadeola");

                entity.Property(e => e.AddDiagnosis)
                    .HasColumnName("add_diagnosis")
                    .HasMaxLength(500);

                entity.Property(e => e.Adddt)
                    .HasColumnName("adddt")
                    .HasColumnType("date");

                entity.Property(e => e.ChargesApproved).HasColumnType("money");

                entity.Property(e => e.ChargesSent).HasColumnType("money");

                entity.Property(e => e.Classification).HasMaxLength(100);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.ConsultancyDate).HasColumnType("datetime");

                entity.Property(e => e.ConsultancyFee).HasColumnType("money");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Diagnosis).HasMaxLength(200);

                entity.Property(e => e.Disdt)
                    .HasColumnName("disdt")
                    .HasColumnType("date");

                entity.Property(e => e.EmployeeName).HasMaxLength(150);

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Formno)
                    .IsRequired()
                    .HasColumnName("formno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("ID_Product")
                    .HasMaxLength(50);

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.Month).HasColumnName("month");

                entity.Property(e => e.Protype).HasMaxLength(3);

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Sno)
                    .HasColumnName("sno")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TreatmentDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(50);

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<Bkbanda>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bkbanda");

                entity.Property(e => e.Classification)
                    .HasColumnName("classification")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Refer)
                    .HasColumnName("refer")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Unit)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bkbandb2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bkbandb2");

                entity.Property(e => e.Classification)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bkbandsp2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bkbandsp2");

                entity.Property(e => e.Classification)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bksumadeola>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bksumadeola");

                entity.Property(e => e.ChargesApproved).HasColumnType("money");

                entity.Property(e => e.ChargesSent).HasColumnType("money");

                entity.Property(e => e.ConsultancyDate).HasColumnType("datetime");

                entity.Property(e => e.Day).HasMaxLength(2);

                entity.Property(e => e.EmployeeName).HasMaxLength(150);

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Formno)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.Month)
                    .HasColumnName("month")
                    .HasMaxLength(2);

                entity.Property(e => e.Protype).HasMaxLength(3);

                entity.Property(e => e.RealChargSent)
                    .HasColumnName("realChargSent")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TreatmentDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(50);

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<BloodGroupTb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BloodGroupTB");

                entity.Property(e => e.BloodGroupType)
                    .IsRequired()
                    .HasColumnName("BLOOD_GROUP_TYPE")
                    .HasMaxLength(20);

                entity.Property(e => e.GroupDescription)
                    .HasColumnName("GROUP_DESCRIPTION")
                    .HasMaxLength(20);

                entity.Property(e => e.SpecificMedication)
                    .HasColumnName("SPECIFIC_MEDICATION")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<CapReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CapReport");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdCapitation).HasColumnName("ID_capitation");

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Narration)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OtherName).HasMaxLength(30);

                entity.Property(e => e.PolicyDetail)
                    .HasColumnName("Policy Detail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Rtype)
                    .HasColumnName("RType")
                    .HasMaxLength(1);

                entity.Property(e => e.Surname).HasMaxLength(30);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CapView1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("cap_view1");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChqInvNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdBranch).HasColumnName("ID_Branch");

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Narration)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OtherName).HasMaxLength(30);

                entity.Property(e => e.PolicyNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Rtype)
                    .HasColumnName("RType")
                    .HasMaxLength(1);

                entity.Property(e => e.Sbu)
                    .HasColumnName("SBU")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Surname).HasMaxLength(30);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.Property(e => e.VoucherNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CapView2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("cap_view2");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChqInvNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdBranch).HasColumnName("ID_Branch");

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Narration)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OtherName).HasMaxLength(30);

                entity.Property(e => e.PolicyNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Rtype)
                    .HasColumnName("RType")
                    .HasMaxLength(1);

                entity.Property(e => e.Sbu)
                    .HasColumnName("SBU")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Surname).HasMaxLength(30);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.Property(e => e.VoucherNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Capitation>(entity =>
            {
                entity.HasKey(e => e.IdCapitation)
                    .HasName("PK_Capitation_1");

                entity.Property(e => e.IdCapitation).HasColumnName("ID_capitation");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CapPymtId).HasColumnName("CapPymtID");

                entity.Property(e => e.ChqInvNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GlpostDate)
                    .HasColumnName("GLPostDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.Narration)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OtherName).HasMaxLength(30);

                entity.Property(e => e.PolicyNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostedBy)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReqDtlId).HasColumnName("ReqDtlID");

                entity.Property(e => e.ReqMstId).HasColumnName("ReqMstID");

                entity.Property(e => e.Rtype)
                    .HasColumnName("RType")
                    .HasMaxLength(1);

                entity.Property(e => e.Surname).HasMaxLength(30);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.Property(e => e.VoucherNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CapitationHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Capitation_History");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IdCapitation).HasColumnName("ID_Capitation");

                entity.Property(e => e.IdCapitationHistory)
                    .HasColumnName("ID_Capitation_History")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.PayIdCapitation).HasColumnName("Pay_ID_Capitation");

                entity.Property(e => e.PolicyNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.ValueDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CapitationSumRpt>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CompanyName).HasMaxLength(120);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.MthDesc).HasMaxLength(3);

                entity.Property(e => e.Yr).HasMaxLength(4);
            });

            modelBuilder.Entity<CapitationX>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CapPymtId).HasColumnName("CapPymtID");

                entity.Property(e => e.ChqInvNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GlpostDate)
                    .HasColumnName("GLPostDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCapitationX)
                    .HasColumnName("ID_CapitationX")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.Narration)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostedBy)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReqDtlId).HasColumnName("ReqDtlID");

                entity.Property(e => e.ReqMstId).HasColumnName("ReqMstID");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.Property(e => e.VoucherNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CATEGORY");

                entity.Property(e => e.Category1)
                    .HasColumnName("CATEGORY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCat)
                    .HasColumnName("ID_CAT")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ChangeProvider>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Changedby).HasMaxLength(50);

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeNo).HasMaxLength(50);

                entity.Property(e => e.Employeestatus).HasMaxLength(1);

                entity.Property(e => e.IdCompany).HasColumnName("Id_Company");

                entity.Property(e => e.IdProviderNew).HasColumnName("ID_ProviderNew");

                entity.Property(e => e.IdProviderOld).HasColumnName("ID_ProviderOld");

                entity.Property(e => e.ProviderNameNew).HasMaxLength(35);

                entity.Property(e => e.ProviderNameOld).HasMaxLength(35);

                entity.Property(e => e.Sno)
                    .HasColumnName("sno")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TransDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Changeprovider2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CHANGEPROVIDER2");

                entity.Property(e => e.Changedby).HasMaxLength(50);

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeNo).HasMaxLength(50);

                entity.Property(e => e.Employeestatus).HasMaxLength(1);

                entity.Property(e => e.IdCompany).HasColumnName("Id_Company");

                entity.Property(e => e.IdProviderNew).HasColumnName("ID_ProviderNew");

                entity.Property(e => e.IdProviderOld).HasColumnName("ID_ProviderOld");

                entity.Property(e => e.ProviderNameNew).HasMaxLength(150);

                entity.Property(e => e.ProviderNameOld).HasMaxLength(150);

                entity.Property(e => e.Sno)
                    .HasColumnName("sno")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.Treated)
                    .HasColumnName("TREATED")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ChangprovView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ChangprovView");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("ID_company");

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(101)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cheque>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmountinWord).HasMaxLength(200);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.IdPay)
                    .HasColumnName("ID_Pay")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Pay).HasMaxLength(50);

                entity.Property(e => e.PayCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClaimDiagnosis>(entity =>
            {
                entity.HasKey(e => e.IdClaimDiagnosis);

                entity.Property(e => e.IdClaimDiagnosis).HasColumnName("ID_ClaimDiagnosis");

                entity.Property(e => e.Details)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdDiagnosis).HasColumnName("ID_Diagnosis");

                entity.Property(e => e.IdReturns).HasColumnName("ID_Returns");
            });

            modelBuilder.Entity<ClaimTreatments>(entity =>
            {
                entity.HasKey(e => e.IdClaimTreatment);

                entity.Property(e => e.IdClaimTreatment).HasColumnName("ID_ClaimTreatment");

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Descriptions)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.IdReturn).HasColumnName("ID_Return");

                entity.Property(e => e.IdTreatmentClass)
                    .HasColumnName("ID_TreatmentClass")
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Claims>(entity =>
            {
                entity.HasKey(e => e.IdClaims);

                entity.Property(e => e.IdClaims).HasColumnName("ID_Claims");

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IdDiffReason).HasColumnName("ID_DiffReason");

                entity.Property(e => e.IdReturn).HasColumnName("ID_Return");

                entity.Property(e => e.IdTreatmentList)
                    .HasColumnName("ID_TreatmentList")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderCost).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<ClaimsMtb>(entity =>
            {
                entity.HasKey(e => e.Formno);

                entity.ToTable("ClaimsMTb");

                entity.Property(e => e.Formno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChargesApproved).HasColumnType("money");

                entity.Property(e => e.ChargesSent).HasColumnType("money");

                entity.Property(e => e.ConsultancyDate).HasColumnType("datetime");

                entity.Property(e => e.Day).HasMaxLength(2);

                entity.Property(e => e.EmployeeName).HasMaxLength(150);

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.Month)
                    .HasColumnName("month")
                    .HasMaxLength(2);

                entity.Property(e => e.Protype).HasMaxLength(3);

                entity.Property(e => e.RealChargSent)
                    .HasColumnName("realChargSent")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TreatmentDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(50);

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<ClaimsMtbDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AddDiagnosis)
                    .HasColumnName("add_diagnosis")
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Adddt)
                    .HasColumnName("adddt")
                    .HasColumnType("date");

                entity.Property(e => e.ChargesApproved).HasColumnType("money");

                entity.Property(e => e.ChargesSent).HasColumnType("money");

                entity.Property(e => e.Classification).HasMaxLength(100);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.ConsultancyDate).HasColumnType("datetime");

                entity.Property(e => e.ConsultancyFee).HasColumnType("money");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Diagnosis).HasMaxLength(200);

                entity.Property(e => e.Disdt)
                    .HasColumnName("disdt")
                    .HasColumnType("date");

                entity.Property(e => e.EmployeeName).HasMaxLength(150);

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Formno)
                    .IsRequired()
                    .HasColumnName("formno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("ID_Product")
                    .HasMaxLength(50);

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.Month).HasColumnName("month");

                entity.Property(e => e.Protype).HasMaxLength(3);

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Sno)
                    .HasColumnName("sno")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TreatmentDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(50);

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<ClaimsMtbDetailN>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ChargesApproved).HasColumnType("money");

                entity.Property(e => e.ChargesSent).HasColumnType("money");

                entity.Property(e => e.Classification).HasMaxLength(50);

                entity.Property(e => e.Comment).HasMaxLength(250);

                entity.Property(e => e.ConsultancyDate).HasColumnType("datetime");

                entity.Property(e => e.ConsultancyFee).HasColumnType("money");

                entity.Property(e => e.Day).HasMaxLength(2);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Diagnosis).HasMaxLength(200);

                entity.Property(e => e.EmployeeName).HasMaxLength(150);

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Formno)
                    .IsRequired()
                    .HasColumnName("formno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany)
                    .HasColumnName("ID_Company")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdProvider)
                    .HasColumnName("ID_Provider")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Month)
                    .HasColumnName("month")
                    .HasMaxLength(2);

                entity.Property(e => e.Protype).HasMaxLength(3);

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Sno)
                    .HasColumnName("sno")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TreatmentDate).HasColumnType("datetime");

                entity.Property(e => e.UpsizeTs)
                    .IsRequired()
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UserId).HasMaxLength(50);

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<ClaimsMtbn>(entity =>
            {
                entity.HasKey(e => e.Formno);

                entity.ToTable("ClaimsMTBN");

                entity.Property(e => e.Formno)
                    .HasColumnName("formno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChargesApproved).HasColumnType("money");

                entity.Property(e => e.ChargesSent).HasColumnType("money");

                entity.Property(e => e.ConsultancyDate).HasColumnType("datetime");

                entity.Property(e => e.Day).HasMaxLength(2);

                entity.Property(e => e.EmployeeName).HasMaxLength(150);

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Fcode)
                    .HasColumnName("FCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany)
                    .HasColumnName("ID_Company")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdProvider)
                    .HasColumnName("ID_Provider")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Month)
                    .HasColumnName("month")
                    .HasMaxLength(2);

                entity.Property(e => e.Protype).HasMaxLength(3);

                entity.Property(e => e.TreatmentDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(50);

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<ClaimsNotes>(entity =>
            {
                entity.HasKey(e => e.EmployeeNo);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate)
                    .HasColumnName("insertDate")
                    .HasColumnType("date");

                entity.Property(e => e.ModifyDate).HasColumnType("date");

                entity.Property(e => e.NoteHistory)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Notes)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UserId)
                    .HasColumnName("userId")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Classification>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdClassification)
                    .HasColumnName("ID_Classification")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Classify>(entity =>
            {
                entity.HasKey(e => e.IdClass);

                entity.ToTable("classify");

                entity.Property(e => e.IdClass)
                    .HasColumnName("ID_Class")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Classification)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClientOfficer>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Comments).HasMaxLength(100);

                entity.Property(e => e.Department).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficerCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.OtherNames).HasMaxLength(50);

                entity.Property(e => e.SurName).HasMaxLength(50);

                entity.Property(e => e.Telephone).HasMaxLength(50);

                entity.Property(e => e.UserId).HasMaxLength(30);
            });

            modelBuilder.Entity<CommentEnr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("commentEnr");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Readremark)
                    .HasColumnName("readremark")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Subject)
                    .HasColumnName("subject")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Comments>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("comments");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Readremark)
                    .HasColumnName("readremark")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Subject)
                    .HasColumnName("subject")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Comments2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("comments2");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Readremark)
                    .HasColumnName("readremark")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Subject)
                    .HasColumnName("subject")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Comments3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("comments3");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Readremark)
                    .HasColumnName("readremark")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Subject)
                    .HasColumnName("subject")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Commission>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AgentCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChqInvNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlpostDate)
                    .HasColumnName("GLPostDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCommission)
                    .HasColumnName("ID_Commission")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdPremium).HasColumnName("ID_Premium");

                entity.Property(e => e.Narration)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PostedBy)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.Property(e => e.VoucherNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Commissions>(entity =>
            {
                entity.HasKey(e => e.CommisionId);

                entity.Property(e => e.CommisionId).HasColumnName("CommisionID");

                entity.Property(e => e.AgentCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GlpostDate)
                    .HasColumnName("GLPostDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("ID_product")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IdReqMaster).HasColumnName("ID_ReqMaster");

                entity.Property(e => e.Narration)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostPeriod)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PostedBy)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Premium).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PremiumId).HasColumnName("PremiumID");

                entity.Property(e => e.Rate).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.TransType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.Property(e => e.VatId).HasColumnName("VatID");

                entity.Property(e => e.VoucherNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CompPayAmtD>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AmtPaid).HasColumnType("money");

                entity.Property(e => e.Bank).HasMaxLength(50);

                entity.Property(e => e.Begindt)
                    .HasColumnName("begindt")
                    .HasColumnType("date");

                entity.Property(e => e.BillType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ChequeNo).HasMaxLength(20);

                entity.Property(e => e.CompanyCode).HasMaxLength(10);

                entity.Property(e => e.CompanyName).HasMaxLength(60);

                entity.Property(e => e.EmployeeNo).HasMaxLength(50);

                entity.Property(e => e.Enddt)
                    .HasColumnName("enddt")
                    .HasColumnType("date");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModeOfPayment).HasMaxLength(10);

                entity.Property(e => e.PayId)
                    .HasColumnName("Pay_Id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ReceiptNo).HasMaxLength(15);

                entity.Property(e => e.Remark).HasColumnType("ntext");

                entity.Property(e => e.Transdate).HasColumnType("date");
            });

            modelBuilder.Entity<CompPayBillD>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AmtExpected).HasColumnType("money");

                entity.Property(e => e.BillId)
                    .HasColumnName("Bill_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BillType).HasMaxLength(1);

                entity.Property(e => e.Cancel)
                    .HasColumnName("cancel")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CompanyCode).HasMaxLength(10);

                entity.Property(e => e.CompanyName).HasMaxLength(150);

                entity.Property(e => e.Confirmed)
                    .HasColumnName("confirmed")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmployeeNo).HasMaxLength(50);

                entity.Property(e => e.InvoiceNo).HasMaxLength(15);

                entity.Property(e => e.Paid)
                    .HasColumnName("paid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Part).HasDefaultValueSql("((0))");

                entity.Property(e => e.PeriodFrom).HasColumnType("datetime");

                entity.Property(e => e.PeriodTo).HasColumnType("datetime");

                entity.Property(e => e.Remainbal)
                    .HasColumnName("remainbal")
                    .HasColumnType("money");

                entity.Property(e => e.Remark).HasColumnType("ntext");

                entity.Property(e => e.TransDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CompPayMaster>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AddedBill).HasColumnType("money");

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.CompanyCode).HasMaxLength(15);

                entity.Property(e => e.CompanyName).HasMaxLength(60);

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.MrecId)
                    .HasColumnName("MRec_Id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NewBill).HasColumnType("money");

                entity.Property(e => e.Payment).HasColumnType("money");

                entity.Property(e => e.PaymentAnalysis).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(1);
            });

            modelBuilder.Entity<CompPayment>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AmtExpected).HasColumnType("money");

                entity.Property(e => e.AmtPaid).HasColumnType("money");

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.Bank).HasMaxLength(50);

                entity.Property(e => e.CheckNo).HasMaxLength(50);

                entity.Property(e => e.CompanyCode).HasMaxLength(50);

                entity.Property(e => e.CompanyName).HasMaxLength(150);

                entity.Property(e => e.CompanyNo).HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EmployeeNo).HasMaxLength(50);

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.ModeOfPayment).HasMaxLength(50);

                entity.Property(e => e.PaymentAnalysis).HasMaxLength(50);

                entity.Property(e => e.ReceiptNo).HasMaxLength(50);

                entity.Property(e => e.Remark).HasColumnType("ntext");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.IdCompany);

                entity.HasIndex(e => e.CompanyName)
                    .HasName("Key_Company_CompanyName")
                    .IsUnique();

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgentCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BalanceC).HasColumnName("balanceC");

                entity.Property(e => e.BalancePre).HasColumnName("balancePre");

                entity.Property(e => e.BalanceT).HasColumnName("balanceT");

                entity.Property(e => e.BeginDt).HasColumnType("date");

                entity.Property(e => e.BizLine)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BoardofDirectors)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Category).HasMaxLength(1);

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CompCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyLogo)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactOfficer)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.CoyPmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Datemove).HasMaxLength(12);

                entity.Property(e => e.DirectorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasColumnName("email2")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("EMailAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpiryDt).HasColumnType("date");

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GlprmAcctNo)
                    .HasColumnName("GLPrmAcctNo")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.Gsmnumber)
                    .HasColumnName("GSMNumber")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IdState)
                    .HasColumnName("ID_State")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.InitialPrdId)
                    .HasColumnName("InitialPrdID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.InitialRegDt).HasColumnType("date");

                entity.Property(e => e.Notes)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.OfficerCode).HasMaxLength(10);

                entity.Property(e => e.PaymentGap).HasDefaultValueSql("((12))");

                entity.Property(e => e.PhoneNumbers)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasMaxLength(1);

                entity.Property(e => e.UserMove).HasMaxLength(20);

                entity.Property(e => e.WebsiteAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CompanyO>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("companyO");

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgentCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BeginDt).HasColumnType("date");

                entity.Property(e => e.Category).HasMaxLength(1);

                entity.Property(e => e.CompCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactOfficer)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.CoyPmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Datemove).HasMaxLength(12);

                entity.Property(e => e.Email2)
                    .HasColumnName("email2")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Enrolleno).HasColumnName("enrolleno");

                entity.Property(e => e.ExpiryDt).HasColumnType("date");

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany)
                    .HasColumnName("ID_Company")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdState)
                    .HasColumnName("ID_State")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.InitialRegDt).HasColumnType("date");

                entity.Property(e => e.OfficerCode).HasMaxLength(10);

                entity.Property(e => e.PhoneNumbers)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasMaxLength(1);

                entity.Property(e => e.UserMove).HasMaxLength(20);
            });

            modelBuilder.Entity<ComplainEndResult>(entity =>
            {
                entity.HasKey(e => e.IdComplainEndResult);

                entity.Property(e => e.IdComplainEndResult)
                    .HasColumnName("ID_ComplainEndResult")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.EndResult)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ComplainTypes>(entity =>
            {
                entity.HasKey(e => e.IdComplainType);

                entity.Property(e => e.IdComplainType)
                    .HasColumnName("ID_ComplainType")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ComplainType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Complains>(entity =>
            {
                entity.HasKey(e => e.IdComplain);

                entity.Property(e => e.IdComplain).HasColumnName("ID_Complain");

                entity.Property(e => e.ActionTaken)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.CallerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ComplainDate).HasColumnType("datetime");

                entity.Property(e => e.ComplainDetails)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Complainby)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DateReceived).HasColumnType("datetime");

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdComplainEndResult)
                    .HasColumnName("ID_ComplainEndResult")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IdComplainType)
                    .HasColumnName("ID_ComplainType")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.ReceivedBy)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CorpBenefits>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CORP_BENEFITS");

                entity.Property(e => e.Amt).HasColumnName("AMT");

                entity.Property(e => e.Bronze)
                    .HasColumnName("BRONZE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bronzel)
                    .HasColumnName("BRONZEL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Count).HasColumnName("COUNT");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Essential)
                    .HasColumnName("ESSENTIAL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Essentiall)
                    .HasColumnName("ESSENTIALL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gold)
                    .HasColumnName("GOLD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Goldl)
                    .HasColumnName("GOLDL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Platinium)
                    .HasColumnName("PLATINIUM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Platiniuml)
                    .HasColumnName("PLATINIUML")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Silver)
                    .HasColumnName("SILVER")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Silverl)
                    .HasColumnName("SILVERL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CountAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("countALL");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Tdate).HasColumnType("date");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CountdepAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("countdepALL");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Tdate).HasColumnType("date");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CountryCodeTb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CountryCodeTB");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasMaxLength(15);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<CoverTbl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("COVER_TBL");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Covertype>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CoyLogin>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Coy_Login");

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgentCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BalanceC).HasColumnName("balanceC");

                entity.Property(e => e.BalancePre).HasColumnName("balancePre");

                entity.Property(e => e.BalanceT).HasColumnName("balanceT");

                entity.Property(e => e.BeginDt).HasColumnType("date");

                entity.Property(e => e.BizLine)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BoardofDirectors)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Category).HasMaxLength(1);

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CompCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyLogo)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactOfficer)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.CoyPmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Datemove).HasMaxLength(12);

                entity.Property(e => e.DirectorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasColumnName("email2")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("EMailAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Encounter)
                    .HasColumnName("encounter")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ExpiryDt).HasColumnType("date");

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GlprmAcctNo)
                    .HasColumnName("GLPrmAcctNo")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.Gsmnumber)
                    .HasColumnName("GSMNumber")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdState)
                    .HasColumnName("ID_State")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Imgfile)
                    .HasColumnName("imgfile")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.InitialPrdId)
                    .HasColumnName("InitialPrdID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.InitialRegDt).HasColumnType("date");

                entity.Property(e => e.LastLogin)
                    .HasColumnName("Last_Login")
                    .HasColumnType("datetime");

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.OfficerCode).HasMaxLength(10);

                entity.Property(e => e.PhoneNumbers)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasMaxLength(1);

                entity.Property(e => e.UserMove).HasMaxLength(20);

                entity.Property(e => e.WebsiteAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CoyPortal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Coy_Portal");

                entity.Property(e => e.Encounter)
                    .HasColumnName("encounter")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.Imgfile)
                    .HasColumnName("imgfile")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LastLogin)
                    .HasColumnName("Last_Login")
                    .HasColumnType("datetime");

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Coypol>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("coypol");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdPolicy).HasColumnName("ID_Policy");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("ID_Product")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CrNoteDetail>(entity =>
            {
                entity.HasKey(e => e.IdCrNoteDetail);

                entity.Property(e => e.IdCrNoteDetail).HasColumnName("ID_CrNoteDetail");

                entity.Property(e => e.CrNoteAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdCrNoteMaster).HasColumnName("ID_CrNoteMaster");

                entity.Property(e => e.Narration)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PremiumId).HasColumnName("PremiumID");
            });

            modelBuilder.Entity<CrNoteMaster>(entity =>
            {
                entity.HasKey(e => e.IdCrNoteMaster);

                entity.Property(e => e.IdCrNoteMaster).HasColumnName("ID_CrNoteMaster");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CapturedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrNoteAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.Narration)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.ValueDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Crmview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("crmview");

                entity.Property(e => e.Address01)
                    .HasColumnName("Address_01")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Address02)
                    .HasColumnName("Address_02")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.BloodGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeProvfrom).HasMaxLength(60);

                entity.Property(e => e.Checking).HasColumnName("checking");

                entity.Property(e => e.ChgDate).HasColumnType("datetime");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentIdCapitation)
                    .HasColumnName("Current_ID_Capitation")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrentIdPolicy)
                    .HasColumnName("Current_ID_Policy")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentIdPremiun)
                    .HasColumnName("Current_ID_Premiun")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DateOfBrith).HasColumnType("datetime");

                entity.Property(e => e.DateReceived).HasColumnType("datetime");

                entity.Property(e => e.Datemove).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Genotype)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Gsmnumber)
                    .HasColumnName("GSMNumber")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.HistoryDate).HasColumnType("datetime");

                entity.Property(e => e.HistoryDesc).HasMaxLength(250);

                entity.Property(e => e.HistoryTransDate).HasColumnType("datetime");

                entity.Property(e => e.IdBranch).HasColumnName("ID_Branch");

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdDesignation).HasColumnName("ID_Designation");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.IdLga)
                    .HasColumnName("ID_LGA")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IdNationality)
                    .HasColumnName("ID_Nationality")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdOccupation)
                    .HasColumnName("ID_Occupation")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.IdProduct)
                    .HasColumnName("ID_Product")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.IdSickness).HasColumnName("ID_Sickness");

                entity.Property(e => e.IdState)
                    .HasColumnName("ID_State")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Idcard)
                    .HasColumnName("IDCard")
                    .HasMaxLength(1);

                entity.Property(e => e.IdcardDate)
                    .HasColumnName("IDCardDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdcardTotal)
                    .HasColumnName("IDCardTotal")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ImageFileName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IncDate).HasColumnType("datetime");

                entity.Property(e => e.Inclusion).HasMaxLength(1);

                entity.Property(e => e.JobLevel)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MartialStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NextOfKin)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sbu)
                    .HasColumnName("SBU")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sn).HasColumnName("sn");

                entity.Property(e => e.StaffNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tdate).HasColumnType("date");

                entity.Property(e => e.TerminalDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TypeMove).HasMaxLength(1);

                entity.Property(e => e.Usermove)
                    .HasColumnName("usermove")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Delta>(entity =>
            {
                entity.Property(e => e.DeltaId).HasColumnName("DeltaID");

                entity.Property(e => e.Charges).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdDeltaType)
                    .HasColumnName("ID_DeltaType")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IdReason).HasColumnName("ID_Reason");

                entity.Property(e => e.NewData).HasColumnType("text");

                entity.Property(e => e.OldData).HasColumnType("text");

                entity.Property(e => e.PolicyNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostPrd)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DeltaDesignation>(entity =>
            {
                entity.HasKey(e => e.IdDeltaDesignation);

                entity.Property(e => e.IdDeltaDesignation).HasColumnName("ID_DeltaDesignation");

                entity.Property(e => e.Comments)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DeltaId).HasColumnName("DeltaID");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NewDesignationId).HasColumnName("NewDesignationID");

                entity.Property(e => e.OldDesignationId).HasColumnName("OldDesignationID");

                entity.Property(e => e.PolicyNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DeltaEmployeeNo>(entity =>
            {
                entity.HasKey(e => e.IdDeltaEmpNo);

                entity.Property(e => e.IdDeltaEmpNo).HasColumnName("ID_DeltaEmpNo");

                entity.Property(e => e.Comments)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DeltaId).HasColumnName("DeltaID");

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NewEmployeeNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OldEmployeeNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DeltaPolicy>(entity =>
            {
                entity.HasKey(e => e.IdDeltaPlc);

                entity.Property(e => e.IdDeltaPlc).HasColumnName("ID_DeltaPlc");

                entity.Property(e => e.Comments)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DeltaId).HasColumnName("DeltaID");

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NewPolicyNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OldPolicyNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DeltaProduct>(entity =>
            {
                entity.HasKey(e => e.IdDeltaPrd);

                entity.Property(e => e.IdDeltaPrd).HasColumnName("ID_DeltaPrd");

                entity.Property(e => e.Comments)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DeltaId).HasColumnName("DeltaID");

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NewProductId)
                    .IsRequired()
                    .HasColumnName("NewProductID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.OldProductId)
                    .IsRequired()
                    .HasColumnName("OldProductID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DeltaProvider>(entity =>
            {
                entity.HasKey(e => e.IdDeltaPrv);

                entity.Property(e => e.IdDeltaPrv).HasColumnName("ID_DeltaPrv");

                entity.Property(e => e.Cap2Pay).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Comments)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DeltaId).HasColumnName("DeltaID");

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NewProviderId).HasColumnName("NewProviderID");

                entity.Property(e => e.OldProviderId).HasColumnName("OldProviderID");

                entity.Property(e => e.PolicyNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DeltaResons>(entity =>
            {
                entity.HasKey(e => e.IdReason);

                entity.HasIndex(e => e.Reason)
                    .HasName("Key_DeltaResons_Reason")
                    .IsUnique();

                entity.Property(e => e.IdReason).HasColumnName("ID_Reason");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeltaType>(entity =>
            {
                entity.HasKey(e => e.IdDeltaType);

                entity.HasIndex(e => e.AlterationDescr)
                    .HasName("FK_DeltaType_Alteration")
                    .IsUnique();

                entity.Property(e => e.IdDeltaType)
                    .HasColumnName("ID_DeltaType")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AlterationDescr)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DepSbu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Dep_SBU");

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.BloodGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CauseOfDeath)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeProvFrom).HasMaxLength(60);

                entity.Property(e => e.Checking).HasColumnName("checking");

                entity.Property(e => e.ChgDate).HasColumnType("datetime");

                entity.Property(e => e.CommenceDate).HasColumnType("date");

                entity.Property(e => e.CurrentIdCapitation)
                    .HasColumnName("Current_ID_Capitation")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrentIdCapitation1).HasColumnName("Current_ID_Capitation1");

                entity.Property(e => e.CurrentIdPolicy)
                    .HasColumnName("Current_ID_Policy")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentIdPremiun)
                    .HasColumnName("Current_ID_Premiun")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrentIdPremiun1).HasColumnName("Current_ID_Premiun1");

                entity.Property(e => e.DateReceived).HasColumnType("datetime");

                entity.Property(e => e.Datemove)
                    .HasColumnName("datemove")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Genotype)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IdBranch).HasColumnName("ID_Branch");

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdDependant).HasColumnName("ID_Dependant");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("ID_Product")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.IdSickness).HasColumnName("ID_Sickness");

                entity.Property(e => e.Idcard)
                    .HasColumnName("IDCard")
                    .HasMaxLength(1);

                entity.Property(e => e.IdcardDate)
                    .HasColumnName("IDCardDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdcardTotal).HasColumnName("IDCardTotal");

                entity.Property(e => e.ImageFileName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IncDate).HasColumnType("datetime");

                entity.Property(e => e.Inclusion).HasMaxLength(1);

                entity.Property(e => e.Name)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RelationType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Tdate).HasColumnType("date");

                entity.Property(e => e.TerminalDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TypeMove).HasMaxLength(1);

                entity.Property(e => e.Usermove)
                    .HasColumnName("usermove")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Depcount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("depcount");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");
            });

            modelBuilder.Entity<Depcountcoy>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("depcountcoy");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdDependant).HasColumnName("ID_Dependant");
            });

            modelBuilder.Entity<Depcrm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("depcrm");

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.BloodGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CauseOfDeath)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeProvFrom).HasMaxLength(60);

                entity.Property(e => e.Checking).HasColumnName("checking");

                entity.Property(e => e.ChgDate).HasColumnType("datetime");

                entity.Property(e => e.CommenceDate).HasColumnType("date");

                entity.Property(e => e.CurrentIdCapitation)
                    .HasColumnName("Current_ID_Capitation")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrentIdCapitation1).HasColumnName("Current_ID_Capitation1");

                entity.Property(e => e.CurrentIdPolicy)
                    .HasColumnName("Current_ID_Policy")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentIdPremiun)
                    .HasColumnName("Current_ID_Premiun")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrentIdPremiun1).HasColumnName("Current_ID_Premiun1");

                entity.Property(e => e.DateReceived).HasColumnType("datetime");

                entity.Property(e => e.Datemove)
                    .HasColumnName("datemove")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Genotype)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IdBranch).HasColumnName("ID_Branch");

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdDependant).HasColumnName("ID_Dependant");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("ID_Product")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.IdSickness).HasColumnName("ID_Sickness");

                entity.Property(e => e.Idcard)
                    .HasColumnName("IDCard")
                    .HasMaxLength(1);

                entity.Property(e => e.IdcardDate)
                    .HasColumnName("IDCardDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdcardTotal).HasColumnName("IDCardTotal");

                entity.Property(e => e.ImageFileName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IncDate).HasColumnType("datetime");

                entity.Property(e => e.Inclusion).HasMaxLength(1);

                entity.Property(e => e.Name)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RelationType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Sbu)
                    .HasColumnName("SBU")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sn).HasColumnName("sn");

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Tdate).HasColumnType("date");

                entity.Property(e => e.TerminalDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TypeMove).HasMaxLength(1);

                entity.Property(e => e.Usermove)
                    .HasColumnName("usermove")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Depct>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("depct");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Tdate).HasColumnType("date");
            });

            modelBuilder.Entity<Dependant>(entity =>
            {
                entity.HasKey(e => e.IdDependant);

                entity.HasIndex(e => e.EmployeeNo)
                    .HasName("Key_Dependant_EmployeeNo")
                    .IsUnique();

                entity.Property(e => e.IdDependant).HasColumnName("ID_Dependant");

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.BloodGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CauseOfDeath)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeProvFrom).HasMaxLength(60);

                entity.Property(e => e.Checking)
                    .HasColumnName("checking")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ChgDate).HasColumnType("datetime");

                entity.Property(e => e.CommenceDate).HasColumnType("date");

                entity.Property(e => e.CurrentIdCapitation)
                    .HasColumnName("Current_ID_Capitation")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrentIdCapitation1).HasColumnName("Current_ID_Capitation1");

                entity.Property(e => e.CurrentIdPolicy)
                    .HasColumnName("Current_ID_Policy")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentIdPremiun)
                    .HasColumnName("Current_ID_Premiun")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrentIdPremiun1).HasColumnName("Current_ID_Premiun1");

                entity.Property(e => e.DateReceived).HasColumnType("datetime");

                entity.Property(e => e.Datemove)
                    .HasColumnName("datemove")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Genotype)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("ID_Product")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.IdSickness).HasColumnName("ID_Sickness");

                entity.Property(e => e.Idcard)
                    .HasColumnName("IDCard")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdcardDate)
                    .HasColumnName("IDCardDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdcardTotal)
                    .HasColumnName("IDCardTotal")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ImageFileName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IncDate).HasColumnType("datetime");

                entity.Property(e => e.Inclusion)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('M')");

                entity.Property(e => e.Name)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasDefaultValueSql("(' ')");

                entity.Property(e => e.RelationType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Tdate).HasColumnType("date");

                entity.Property(e => e.TerminalDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TypeMove).HasMaxLength(1);

                entity.Property(e => e.Usermove)
                    .HasColumnName("usermove")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Dependant55>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.BloodGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CauseOfDeath)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeProvFrom).HasMaxLength(60);

                entity.Property(e => e.Checking).HasColumnName("checking");

                entity.Property(e => e.ChgDate).HasColumnType("datetime");

                entity.Property(e => e.CommenceDate).HasColumnType("date");

                entity.Property(e => e.CurrentIdCapitation)
                    .HasColumnName("Current_ID_Capitation")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrentIdCapitation1).HasColumnName("Current_ID_Capitation1");

                entity.Property(e => e.CurrentIdPolicy)
                    .HasColumnName("Current_ID_Policy")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentIdPremiun)
                    .HasColumnName("Current_ID_Premiun")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrentIdPremiun1).HasColumnName("Current_ID_Premiun1");

                entity.Property(e => e.DateReceived).HasColumnType("datetime");

                entity.Property(e => e.Datemove)
                    .HasColumnName("datemove")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Genotype)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdDependant).HasColumnName("ID_Dependant");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("ID_Product")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.IdSickness).HasColumnName("ID_Sickness");

                entity.Property(e => e.Idcard)
                    .HasColumnName("IDCard")
                    .HasMaxLength(1);

                entity.Property(e => e.IdcardDate)
                    .HasColumnName("IDCardDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdcardTotal).HasColumnName("IDCardTotal");

                entity.Property(e => e.ImageFileName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IncDate).HasColumnType("datetime");

                entity.Property(e => e.Inclusion).HasMaxLength(1);

                entity.Property(e => e.Name)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RelationType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Tdate).HasColumnType("date");

                entity.Property(e => e.TerminalDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TypeMove).HasMaxLength(1);

                entity.Property(e => e.Usermove)
                    .HasColumnName("usermove")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<DependantHistory>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.BloodGroup).HasMaxLength(30);

                entity.Property(e => e.CauseOfDeath).HasMaxLength(20);

                entity.Property(e => e.ChangeProvFrom).HasMaxLength(60);

                entity.Property(e => e.ChgDate).HasColumnType("datetime");

                entity.Property(e => e.CurrentIdCapitation).HasColumnName("Current_ID_Capitation");

                entity.Property(e => e.CurrentIdPolicy)
                    .HasColumnName("Current_ID_Policy")
                    .HasMaxLength(20);

                entity.Property(e => e.CurrentIdPremiun).HasColumnName("Current_ID_Premiun");

                entity.Property(e => e.Datemove)
                    .HasColumnName("datemove")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Genotype).HasMaxLength(30);

                entity.Property(e => e.HistoryDate).HasColumnType("datetime");

                entity.Property(e => e.HistoryDesc).HasMaxLength(250);

                entity.Property(e => e.HistoryTransDate).HasColumnType("datetime");

                entity.Property(e => e.HistoryType).HasMaxLength(2);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdDependant).HasColumnName("ID_Dependant");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.IdProduct)
                    .IsRequired()
                    .HasColumnName("ID_Product")
                    .HasMaxLength(6);

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.IdSickness)
                    .HasColumnName("ID_Sickness")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdState)
                    .HasColumnName("ID_State")
                    .HasMaxLength(3);

                entity.Property(e => e.Idcard)
                    .HasColumnName("IDCard")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IdcardDate)
                    .HasColumnName("IDCardDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdcardTotal)
                    .HasColumnName("IDCardTotal")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ImageFileName).HasMaxLength(150);

                entity.Property(e => e.IncDate).HasColumnType("datetime");

                entity.Property(e => e.Inclusion)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('M')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.RelationType).HasMaxLength(2);

                entity.Property(e => e.Sex).HasMaxLength(1);

                entity.Property(e => e.StatusId)
                    .IsRequired()
                    .HasColumnName("StatusID")
                    .HasMaxLength(2);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TypeMove).HasMaxLength(1);

                entity.Property(e => e.Usermove)
                    .HasColumnName("usermove")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<DependantO>(entity =>
            {
                entity.HasKey(e => e.IdDependant);

                entity.Property(e => e.IdDependant).HasColumnName("ID_Dependant");

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.BloodGroup).HasMaxLength(30);

                entity.Property(e => e.CauseOfDeath).HasMaxLength(15);

                entity.Property(e => e.ChangeProvFrom).HasMaxLength(60);

                entity.Property(e => e.Checking)
                    .HasColumnName("checking")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ChgDate).HasColumnType("datetime");

                entity.Property(e => e.CommenceDate).HasColumnType("date");

                entity.Property(e => e.CurrentIdCapitation).HasColumnName("Current_ID_Capitation");

                entity.Property(e => e.CurrentIdPolicy)
                    .HasColumnName("Current_ID_Policy")
                    .HasMaxLength(20);

                entity.Property(e => e.CurrentIdPremiun).HasColumnName("Current_ID_Premiun");

                entity.Property(e => e.Datemove)
                    .HasColumnName("datemove")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo).IsUnicode(false);

                entity.Property(e => e.Genotype).HasMaxLength(20);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("ID_Product")
                    .HasMaxLength(6);

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.IdSickness).HasColumnName("ID_Sickness");

                entity.Property(e => e.IdState)
                    .HasColumnName("ID_State")
                    .HasMaxLength(3);

                entity.Property(e => e.Idcard)
                    .HasColumnName("IDCard")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdcardDate)
                    .HasColumnName("IDCardDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdcardTotal)
                    .HasColumnName("IDCardTotal")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ImageFileName).HasMaxLength(150);

                entity.Property(e => e.IncDate).HasColumnType("datetime");

                entity.Property(e => e.Inclusion)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('M')");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RelationType).HasMaxLength(20);

                entity.Property(e => e.Sex).HasMaxLength(1);

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasMaxLength(2);

                entity.Property(e => e.Surname).HasMaxLength(30);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TypeMove).HasMaxLength(1);

                entity.Property(e => e.Usermove)
                    .HasColumnName("usermove")
                    .HasMaxLength(20);

                entity.Property(e => e.Vetted)
                    .HasColumnName("vetted")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Deppoldetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("deppoldetails");

                entity.Property(e => e.BeginDate).HasColumnType("datetime");

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.BloodGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CauseOfDeath)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeProvFrom).HasMaxLength(60);

                entity.Property(e => e.Checking).HasColumnName("checking");

                entity.Property(e => e.ChgDate).HasColumnType("datetime");

                entity.Property(e => e.CommenceDate).HasColumnType("date");

                entity.Property(e => e.CurrentIdCapitation)
                    .HasColumnName("Current_ID_Capitation")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrentIdCapitation1).HasColumnName("Current_ID_Capitation1");

                entity.Property(e => e.CurrentIdPolicy)
                    .HasColumnName("Current_ID_Policy")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentIdPremiun)
                    .HasColumnName("Current_ID_Premiun")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrentIdPremiun1).HasColumnName("Current_ID_Premiun1");

                entity.Property(e => e.DateReceived).HasColumnType("datetime");

                entity.Property(e => e.Datemove)
                    .HasColumnName("datemove")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Genotype)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdDependant).HasColumnName("ID_Dependant");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("ID_Product")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.IdSickness).HasColumnName("ID_Sickness");

                entity.Property(e => e.Idcard)
                    .HasColumnName("IDCard")
                    .HasMaxLength(1);

                entity.Property(e => e.IdcardDate)
                    .HasColumnName("IDCardDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdcardTotal).HasColumnName("IDCardTotal");

                entity.Property(e => e.ImageFileName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IncDate).HasColumnType("datetime");

                entity.Property(e => e.Inclusion).HasMaxLength(1);

                entity.Property(e => e.Name)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ProdName)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.RelationType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Tdate).HasColumnType("date");

                entity.Property(e => e.TerminalDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TypeMove).HasMaxLength(1);

                entity.Property(e => e.Usermove)
                    .HasColumnName("usermove")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Designation>(entity =>
            {
                entity.HasKey(e => e.IdDesignation);

                entity.Property(e => e.IdDesignation).HasColumnName("ID_Designation");

                entity.Property(e => e.Designation1)
                    .HasColumnName("Designation")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DiagnosisList>(entity =>
            {
                entity.HasKey(e => e.IdDiagnosis);

                entity.HasIndex(e => e.Diagnosis)
                    .HasName("Key_DiagnosisList_Diagnosis")
                    .IsUnique();

                entity.Property(e => e.IdDiagnosis).HasColumnName("ID_Diagnosis");

                entity.Property(e => e.Diagnosis)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DiagnosisCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DifferenceReason>(entity =>
            {
                entity.HasKey(e => e.IdReason);

                entity.Property(e => e.IdReason)
                    .HasColumnName("ID_Reason")
                    .ValueGeneratedNever();

                entity.Property(e => e.Narration)
                    .IsRequired()
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DoctorInfoTb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DoctorInfoTB");

                entity.Property(e => e.Area).HasMaxLength(3);

                entity.Property(e => e.AreaOfspecialisation).HasMaxLength(50);

                entity.Property(e => e.DoctorName).HasMaxLength(50);

                entity.Property(e => e.IdDoctor)
                    .HasColumnName("ID_Doctor")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.Institutionattended).HasMaxLength(250);

                entity.Property(e => e.Position).HasMaxLength(70);
            });

            modelBuilder.Entity<DrugTb>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DrugCode).ValueGeneratedOnAdd();

                entity.Property(e => e.DrugGroup)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Drugs).HasMaxLength(255);

                entity.Property(e => e.Unit)
                    .HasColumnName("UNIT")
                    .HasMaxLength(255);

                entity.Property(e => e.Unitprice).HasColumnType("money");
            });

            modelBuilder.Entity<EclaimsMtb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EclaimsMTB");

                entity.Property(e => e.ChargesApproved).HasColumnType("money");

                entity.Property(e => e.ChargesSent).HasColumnType("money");

                entity.Property(e => e.ConsultancyDate).HasColumnType("date");

                entity.Property(e => e.Day).HasMaxLength(2);

                entity.Property(e => e.EmployeeName).HasMaxLength(150);

                entity.Property(e => e.EmployeeNo).HasMaxLength(50);

                entity.Property(e => e.Formno)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.Month)
                    .HasColumnName("month")
                    .HasMaxLength(2);

                entity.Property(e => e.Protype).HasMaxLength(3);

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TreatmentDate).HasColumnType("date");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasMaxLength(50);

                entity.Property(e => e.Vetted)
                    .HasColumnName("vetted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<EclaimsMtbDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Authdate)
                    .HasColumnName("authdate")
                    .HasColumnType("date");

                entity.Property(e => e.Authorcode)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ChargesApproved).HasColumnType("money");

                entity.Property(e => e.ChargesSent).HasColumnType("money");

                entity.Property(e => e.Classification).HasMaxLength(50);

                entity.Property(e => e.Comment).HasMaxLength(250);

                entity.Property(e => e.ConsultancyDate).HasColumnType("date");

                entity.Property(e => e.ConsultancyFee).HasColumnType("money");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Diagnosis).HasMaxLength(200);

                entity.Property(e => e.EmployeeName).HasMaxLength(150);

                entity.Property(e => e.EmployeeNo).HasMaxLength(50);

                entity.Property(e => e.Formno)
                    .HasColumnName("formno")
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("ID_Product")
                    .HasMaxLength(50);

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.Month).HasColumnName("month");

                entity.Property(e => e.Procedure).HasColumnType("ntext");

                entity.Property(e => e.Protype).HasMaxLength(3);

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Sno)
                    .HasColumnName("sno")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TreatmentDate).HasColumnType("date");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasMaxLength(50);

                entity.Property(e => e.Vetted).HasColumnName("vetted");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<EmpDepList>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CurrentIdPolicy)
                    .HasColumnName("Current_ID_Policy")
                    .HasMaxLength(20);

                entity.Property(e => e.DateOfBrith).HasColumnType("datetime");

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("ID_Product")
                    .HasMaxLength(6);

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.IdProviderFrom).HasColumnName("ID_Provider_From");

                entity.Property(e => e.ImageFileName).HasMaxLength(150);

                entity.Property(e => e.Mstatus)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.OperationDate).HasColumnType("datetime");

                entity.Property(e => e.OperationType).HasMaxLength(1);

                entity.Property(e => e.RelationType).HasMaxLength(2);

                entity.Property(e => e.Sex).HasMaxLength(1);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<EmpDepList2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CurrentIdPolicy)
                    .HasColumnName("Current_ID_Policy")
                    .HasMaxLength(20);

                entity.Property(e => e.DateOfBrith).HasColumnType("datetime");

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("ID_Product")
                    .HasMaxLength(6);

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.IdProviderFrom)
                    .HasColumnName("ID_Provider_From")
                    .HasMaxLength(150);

                entity.Property(e => e.ImageFileName).HasMaxLength(150);

                entity.Property(e => e.OperationDate).HasColumnType("datetime");

                entity.Property(e => e.OperationType).HasMaxLength(1);

                entity.Property(e => e.RelationType).HasMaxLength(2);

                entity.Property(e => e.Sex).HasMaxLength(1);

                entity.Property(e => e.Sn).HasColumnName("sn");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Empcount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("empcount");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");
            });

            modelBuilder.Entity<Empcountcoy>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("empcountcoy");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.Tdate).HasColumnType("date");
            });

            modelBuilder.Entity<Empct>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("empct");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Tdate).HasColumnType("date");
            });

            modelBuilder.Entity<Emphist>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("emphist");

                entity.Property(e => e.Classification).HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Diagnosis).HasMaxLength(200);

                entity.Property(e => e.EmployeeName).HasMaxLength(150);

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TreatmentDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.IdEmployee)
                    .HasName("PK_Employee_1");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.Address01)
                    .HasColumnName("Address_01")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Address02)
                    .HasColumnName("Address_02")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.BloodGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeProvfrom).HasMaxLength(60);

                entity.Property(e => e.Checking).HasColumnName("checking");

                entity.Property(e => e.ChgDate).HasColumnType("datetime");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentIdCapitation)
                    .HasColumnName("Current_ID_Capitation")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrentIdPolicy)
                    .HasColumnName("Current_ID_Policy")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentIdPremiun)
                    .HasColumnName("Current_ID_Premiun")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DateOfBrith).HasColumnType("datetime");

                entity.Property(e => e.DateReceived).HasColumnType("datetime");

                entity.Property(e => e.Datemove).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Genotype)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Gsmnumber)
                    .HasColumnName("GSMNumber")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.HistoryDate).HasColumnType("datetime");

                entity.Property(e => e.HistoryDesc).HasMaxLength(250);

                entity.Property(e => e.HistoryTransDate).HasColumnType("datetime");

                entity.Property(e => e.IdBranch)
                    .HasColumnName("ID_Branch")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdDesignation).HasColumnName("ID_Designation");

                entity.Property(e => e.IdLga)
                    .HasColumnName("ID_LGA")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IdNationality)
                    .HasColumnName("ID_Nationality")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdOccupation)
                    .HasColumnName("ID_Occupation")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.IdProduct)
                    .HasColumnName("ID_Product")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.IdSickness).HasColumnName("ID_Sickness");

                entity.Property(e => e.IdState)
                    .HasColumnName("ID_State")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Idcard)
                    .HasColumnName("IDCard")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdcardDate)
                    .HasColumnName("IDCardDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdcardTotal)
                    .HasColumnName("IDCardTotal")
                    .HasMaxLength(10)
                    .IsFixedLength()
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ImageFileName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IncDate).HasColumnType("datetime");

                entity.Property(e => e.Inclusion).HasMaxLength(1);

                entity.Property(e => e.JobLevel)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MartialStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NextOfKin)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StaffNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tdate).HasColumnType("date");

                entity.Property(e => e.TerminalDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TypeMove).HasMaxLength(1);

                entity.Property(e => e.Usermove)
                    .HasColumnName("usermove")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Employee5>(entity =>
            {
                entity.HasKey(e => e.IdEmployee)
                    .HasName("PK_Employee");

                entity.HasIndex(e => e.EmployeeNo)
                    .HasName("Key_Employee_EmployeeNo")
                    .IsUnique();

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.Address01)
                    .HasColumnName("Address_01")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Address02)
                    .HasColumnName("Address_02")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.BloodGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeProvfrom).HasMaxLength(60);

                entity.Property(e => e.Checking)
                    .HasColumnName("checking")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ChgDate).HasColumnType("datetime");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentIdCapitation)
                    .HasColumnName("Current_ID_Capitation")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrentIdPolicy)
                    .HasColumnName("Current_ID_Policy")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentIdPremiun)
                    .HasColumnName("Current_ID_Premiun")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DateOfBrith).HasColumnType("datetime");

                entity.Property(e => e.DateReceived).HasColumnType("datetime");

                entity.Property(e => e.Datemove).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Genotype)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Gsmnumber)
                    .HasColumnName("GSMNumber")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.HistoryDate).HasColumnType("datetime");

                entity.Property(e => e.HistoryDesc).HasMaxLength(250);

                entity.Property(e => e.HistoryTransDate).HasColumnType("datetime");

                entity.Property(e => e.IdBranch).HasColumnName("ID_Branch");

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdDesignation).HasColumnName("ID_Designation");

                entity.Property(e => e.IdLga)
                    .HasColumnName("ID_LGA")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IdNationality)
                    .HasColumnName("ID_Nationality")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdOccupation)
                    .HasColumnName("ID_Occupation")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IdProduct)
                    .HasColumnName("ID_Product")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.IdSickness).HasColumnName("ID_Sickness");

                entity.Property(e => e.IdState)
                    .HasColumnName("ID_State")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Idcard)
                    .HasColumnName("IDCard")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdcardDate)
                    .HasColumnName("IDCardDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdcardTotal)
                    .HasColumnName("IDCardTotal")
                    .HasMaxLength(10)
                    .IsFixedLength()
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ImageFileName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IncDate).HasColumnType("datetime");

                entity.Property(e => e.Inclusion).HasMaxLength(1);

                entity.Property(e => e.JobLevel)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MartialStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NextOfKin)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.PaymentGap).HasDefaultValueSql("((3))");

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StaffNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TypeMove).HasMaxLength(1);

                entity.Property(e => e.Usermove)
                    .HasColumnName("usermove")
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdLgaNavigation)
                    .WithMany(p => p.Employee5)
                    .HasForeignKey(d => d.IdLga)
                    .HasConstraintName("FK_Employee_LGArea");

                entity.HasOne(d => d.IdStateNavigation)
                    .WithMany(p => p.Employee5)
                    .HasForeignKey(d => d.IdState)
                    .HasConstraintName("FK_Employee_States");
            });

            modelBuilder.Entity<Employee55>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Address01)
                    .HasColumnName("Address_01")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Address02)
                    .HasColumnName("Address_02")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.BloodGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeProvfrom).HasMaxLength(60);

                entity.Property(e => e.Checking).HasColumnName("checking");

                entity.Property(e => e.ChgDate).HasColumnType("datetime");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentIdCapitation)
                    .HasColumnName("Current_ID_Capitation")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrentIdPolicy)
                    .HasColumnName("Current_ID_Policy")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentIdPremiun)
                    .HasColumnName("Current_ID_Premiun")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DateOfBrith).HasColumnType("datetime");

                entity.Property(e => e.DateReceived).HasColumnType("datetime");

                entity.Property(e => e.Datemove).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Genotype)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Gsmnumber)
                    .HasColumnName("GSMNumber")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.HistoryDate).HasColumnType("datetime");

                entity.Property(e => e.HistoryDesc).HasMaxLength(250);

                entity.Property(e => e.HistoryTransDate).HasColumnType("datetime");

                entity.Property(e => e.IdBranch).HasColumnName("ID_Branch");

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdDesignation).HasColumnName("ID_Designation");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.IdLga)
                    .HasColumnName("ID_LGA")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IdNationality)
                    .HasColumnName("ID_Nationality")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdOccupation)
                    .HasColumnName("ID_Occupation")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.IdProduct)
                    .HasColumnName("ID_Product")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.IdSickness).HasColumnName("ID_Sickness");

                entity.Property(e => e.IdState)
                    .HasColumnName("ID_State")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Idcard)
                    .HasColumnName("IDCard")
                    .HasMaxLength(1);

                entity.Property(e => e.IdcardDate)
                    .HasColumnName("IDCardDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdcardTotal)
                    .HasColumnName("IDCardTotal")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ImageFileName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IncDate).HasColumnType("datetime");

                entity.Property(e => e.Inclusion).HasMaxLength(1);

                entity.Property(e => e.JobLevel)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MartialStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NextOfKin)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StaffNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tdate).HasColumnType("date");

                entity.Property(e => e.TerminalDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TypeMove).HasMaxLength(1);

                entity.Property(e => e.Usermove)
                    .HasColumnName("usermove")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EmployeeE>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Address01)
                    .HasColumnName("Address_01")
                    .HasMaxLength(50);

                entity.Property(e => e.Address02)
                    .HasColumnName("Address_02")
                    .HasMaxLength(50);

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.BloodGroup).HasMaxLength(20);

                entity.Property(e => e.ChangeProvfrom).HasMaxLength(60);

                entity.Property(e => e.Checking).HasColumnName("checking");

                entity.Property(e => e.ChgDate).HasColumnType("datetime");

                entity.Property(e => e.CurrentIdCapitation).HasColumnName("Current_ID_Capitation");

                entity.Property(e => e.CurrentIdPolicy)
                    .HasColumnName("Current_ID_Policy")
                    .HasMaxLength(20);

                entity.Property(e => e.CurrentIdPremiun).HasColumnName("Current_ID_Premiun");

                entity.Property(e => e.DateOfBrith).HasColumnType("datetime");

                entity.Property(e => e.DateReceived).HasColumnType("datetime");

                entity.Property(e => e.Datemove).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(60);

                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.Genotype).HasMaxLength(25);

                entity.Property(e => e.HistoryDate).HasColumnType("datetime");

                entity.Property(e => e.HistoryDesc).HasMaxLength(250);

                entity.Property(e => e.HistoryTransDate).HasColumnType("datetime");

                entity.Property(e => e.IdBranch).HasColumnName("ID_Branch");

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.IdLga)
                    .HasColumnName("ID_LGA")
                    .HasMaxLength(3);

                entity.Property(e => e.IdNationality)
                    .HasColumnName("ID_Nationality")
                    .HasMaxLength(10);

                entity.Property(e => e.IdOccupation)
                    .HasColumnName("ID_Occupation")
                    .HasMaxLength(4);

                entity.Property(e => e.IdProduct)
                    .HasColumnName("ID_Product")
                    .HasMaxLength(6);

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.IdState)
                    .HasColumnName("ID_State")
                    .HasMaxLength(3);

                entity.Property(e => e.Idcard)
                    .HasColumnName("IDCard")
                    .HasMaxLength(1);

                entity.Property(e => e.IdcardDate)
                    .HasColumnName("IDCardDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdcardTotal).HasColumnName("IDCardTotal");

                entity.Property(e => e.ImageFileName).HasMaxLength(150);

                entity.Property(e => e.IncDate).HasColumnType("datetime");

                entity.Property(e => e.Inclusion).HasMaxLength(1);

                entity.Property(e => e.JobLevel).HasMaxLength(1);

                entity.Property(e => e.MartialStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Newdep).HasColumnName("newdep");

                entity.Property(e => e.NextOfKin).HasMaxLength(30);

                entity.Property(e => e.PhoneNo).HasMaxLength(50);

                entity.Property(e => e.Sex).HasMaxLength(1);

                entity.Property(e => e.StaffNo).HasMaxLength(10);

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasMaxLength(2);

                entity.Property(e => e.Surname).HasMaxLength(30);

                entity.Property(e => e.Tdate).HasColumnType("date");

                entity.Property(e => e.TerminalDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TypeMove).HasMaxLength(1);

                entity.Property(e => e.Usermove)
                    .HasColumnName("usermove")
                    .HasMaxLength(50);

                entity.Property(e => e.Vetted).HasColumnName("vetted");
            });

            modelBuilder.Entity<EmployeeHistory>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Address01)
                    .HasColumnName("Address_01")
                    .HasMaxLength(50);

                entity.Property(e => e.Address02)
                    .HasColumnName("Address_02")
                    .HasMaxLength(50);

                entity.Property(e => e.BloodGroup).HasMaxLength(20);

                entity.Property(e => e.ChangeProvfrom).HasMaxLength(60);

                entity.Property(e => e.ChgDate).HasColumnType("datetime");

                entity.Property(e => e.CurrentIdCapitation).HasColumnName("Current_ID_Capitation");

                entity.Property(e => e.CurrentIdPolicy)
                    .HasColumnName("Current_ID_Policy")
                    .HasMaxLength(20);

                entity.Property(e => e.CurrentIdPremiun).HasColumnName("Current_ID_Premiun");

                entity.Property(e => e.DateOfBrith).HasColumnType("datetime");

                entity.Property(e => e.DateReceived).HasColumnType("datetime");

                entity.Property(e => e.Datemove).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(60);

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.Genotype).HasMaxLength(25);

                entity.Property(e => e.HistoryDate).HasColumnType("datetime");

                entity.Property(e => e.HistoryDesc).HasMaxLength(250);

                entity.Property(e => e.HistoryTransDate).HasColumnType("datetime");

                entity.Property(e => e.HistoryType).HasMaxLength(2);

                entity.Property(e => e.IdBranch).HasColumnName("ID_Branch");

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.IdLga)
                    .HasColumnName("ID_LGA")
                    .HasMaxLength(3);

                entity.Property(e => e.IdNationality)
                    .HasColumnName("ID_Nationality")
                    .HasMaxLength(10);

                entity.Property(e => e.IdOccupation)
                    .HasColumnName("ID_Occupation")
                    .HasMaxLength(20);

                entity.Property(e => e.IdProduct)
                    .HasColumnName("ID_Product")
                    .HasMaxLength(6);

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.IdState)
                    .HasColumnName("ID_State")
                    .HasMaxLength(3);

                entity.Property(e => e.Idcard)
                    .HasColumnName("IDCard")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IdcardDate)
                    .HasColumnName("IDCardDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdcardTotal)
                    .HasColumnName("IDCardTotal")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ImageFileName).HasMaxLength(150);

                entity.Property(e => e.IncDate).HasColumnType("datetime");

                entity.Property(e => e.Inclusion)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('M')");

                entity.Property(e => e.JobLevel).HasMaxLength(1);

                entity.Property(e => e.NextOfKin).HasMaxLength(30);

                entity.Property(e => e.PhoneNo).HasMaxLength(50);

                entity.Property(e => e.Sex).HasMaxLength(1);

                entity.Property(e => e.StaffNo).HasMaxLength(10);

                entity.Property(e => e.StatusId)
                    .IsRequired()
                    .HasColumnName("StatusID")
                    .HasMaxLength(2);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.TerminalDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TypeMove).HasMaxLength(1);

                entity.Property(e => e.Usermove)
                    .HasColumnName("usermove")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EmployeeO>(entity =>
            {
                entity.HasKey(e => e.IdEmployee);

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.Address01)
                    .HasColumnName("Address_01")
                    .HasMaxLength(50);

                entity.Property(e => e.Address02)
                    .HasColumnName("Address_02")
                    .HasMaxLength(50);

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.BloodGroup).HasMaxLength(20);

                entity.Property(e => e.ChangeProvfrom).HasMaxLength(60);

                entity.Property(e => e.Checking).HasColumnName("checking");

                entity.Property(e => e.ChgDate).HasColumnType("datetime");

                entity.Property(e => e.CurrentIdCapitation).HasColumnName("Current_ID_Capitation");

                entity.Property(e => e.CurrentIdPolicy)
                    .HasColumnName("Current_ID_Policy")
                    .HasMaxLength(20);

                entity.Property(e => e.CurrentIdPremiun).HasColumnName("Current_ID_Premiun");

                entity.Property(e => e.DateOfBrith).HasColumnType("datetime");

                entity.Property(e => e.DateReceived).HasColumnType("datetime");

                entity.Property(e => e.Datemove).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(60);

                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.Genotype).HasMaxLength(25);

                entity.Property(e => e.HistoryDate).HasColumnType("datetime");

                entity.Property(e => e.HistoryDesc).HasMaxLength(250);

                entity.Property(e => e.HistoryTransDate).HasColumnType("datetime");

                entity.Property(e => e.IdBranch).HasColumnName("ID_Branch");

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdLga)
                    .HasColumnName("ID_LGA")
                    .HasMaxLength(3);

                entity.Property(e => e.IdNationality)
                    .HasColumnName("ID_Nationality")
                    .HasMaxLength(10);

                entity.Property(e => e.IdOccupation)
                    .HasColumnName("ID_Occupation")
                    .HasMaxLength(4);

                entity.Property(e => e.IdProduct)
                    .HasColumnName("ID_Product")
                    .HasMaxLength(6);

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.IdState)
                    .HasColumnName("ID_State")
                    .HasMaxLength(3);

                entity.Property(e => e.Idcard)
                    .HasColumnName("IDCard")
                    .HasMaxLength(1);

                entity.Property(e => e.IdcardDate)
                    .HasColumnName("IDCardDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdcardTotal).HasColumnName("IDCardTotal");

                entity.Property(e => e.ImageFileName).HasMaxLength(150);

                entity.Property(e => e.IncDate).HasColumnType("datetime");

                entity.Property(e => e.Inclusion).HasMaxLength(1);

                entity.Property(e => e.JobLevel).HasMaxLength(1);

                entity.Property(e => e.MartialStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Newdep).HasColumnName("newdep");

                entity.Property(e => e.NextOfKin).HasMaxLength(30);

                entity.Property(e => e.PhoneNo).HasMaxLength(50);

                entity.Property(e => e.Sex).HasMaxLength(1);

                entity.Property(e => e.StaffNo).HasMaxLength(10);

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasMaxLength(2);

                entity.Property(e => e.Surname).HasMaxLength(30);

                entity.Property(e => e.Tdate).HasColumnType("date");

                entity.Property(e => e.TerminalDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TypeMove).HasMaxLength(1);

                entity.Property(e => e.Usermove)
                    .HasColumnName("usermove")
                    .HasMaxLength(50);

                entity.Property(e => e.Vetted)
                    .HasColumnName("vetted")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<EmployeeSickness>(entity =>
            {
                entity.HasKey(e => e.IdEmployeeSickness);

                entity.Property(e => e.IdEmployeeSickness).HasColumnName("ID_EmployeeSickness");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.IdSickness).HasColumnName("ID_Sickness");

                entity.HasOne(d => d.IdSicknessNavigation)
                    .WithMany(p => p.EmployeeSickness)
                    .HasForeignKey(d => d.IdSickness)
                    .HasConstraintName("FK_EmployeeSickness_Sickness");
            });

            modelBuilder.Entity<Employeebk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EMPLOYEEBK");

                entity.Property(e => e.Address01)
                    .HasColumnName("Address_01")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Address02)
                    .HasColumnName("Address_02")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.BloodGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeProvfrom).HasMaxLength(60);

                entity.Property(e => e.Checking).HasColumnName("checking");

                entity.Property(e => e.ChgDate).HasColumnType("datetime");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentIdCapitation)
                    .HasColumnName("Current_ID_Capitation")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrentIdPolicy)
                    .HasColumnName("Current_ID_Policy")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentIdPremiun)
                    .HasColumnName("Current_ID_Premiun")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DateOfBrith).HasColumnType("datetime");

                entity.Property(e => e.DateReceived).HasColumnType("datetime");

                entity.Property(e => e.Datemove).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Genotype)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Gsmnumber)
                    .HasColumnName("GSMNumber")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.HistoryDate).HasColumnType("datetime");

                entity.Property(e => e.HistoryDesc).HasMaxLength(250);

                entity.Property(e => e.HistoryTransDate).HasColumnType("datetime");

                entity.Property(e => e.IdBranch).HasColumnName("ID_Branch");

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdDesignation).HasColumnName("ID_Designation");

                entity.Property(e => e.IdEmployee)
                    .HasColumnName("ID_Employee")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdLga)
                    .HasColumnName("ID_LGA")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IdNationality)
                    .HasColumnName("ID_Nationality")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdOccupation)
                    .HasColumnName("ID_Occupation")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.IdProduct)
                    .HasColumnName("ID_Product")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.IdSickness).HasColumnName("ID_Sickness");

                entity.Property(e => e.IdState)
                    .HasColumnName("ID_State")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Idcard)
                    .HasColumnName("IDCard")
                    .HasMaxLength(1);

                entity.Property(e => e.IdcardDate)
                    .HasColumnName("IDCardDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdcardTotal)
                    .HasColumnName("IDCardTotal")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ImageFileName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IncDate).HasColumnType("datetime");

                entity.Property(e => e.Inclusion).HasMaxLength(1);

                entity.Property(e => e.JobLevel)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MartialStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NextOfKin)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StaffNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tdate).HasColumnType("date");

                entity.Property(e => e.TerminalDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TypeMove).HasMaxLength(1);

                entity.Property(e => e.Usermove)
                    .HasColumnName("usermove")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Emppoldetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("emppoldetails");

                entity.Property(e => e.Address01)
                    .HasColumnName("Address_01")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Address02)
                    .HasColumnName("Address_02")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.BeginDate).HasColumnType("datetime");

                entity.Property(e => e.BloodGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeProvfrom).HasMaxLength(60);

                entity.Property(e => e.Checking).HasColumnName("checking");

                entity.Property(e => e.ChgDate).HasColumnType("datetime");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentIdCapitation)
                    .HasColumnName("Current_ID_Capitation")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrentIdPolicy)
                    .HasColumnName("Current_ID_Policy")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentIdPremiun)
                    .HasColumnName("Current_ID_Premiun")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DateOfBrith).HasColumnType("datetime");

                entity.Property(e => e.DateReceived).HasColumnType("datetime");

                entity.Property(e => e.Datemove).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Genotype)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Gsmnumber)
                    .HasColumnName("GSMNumber")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.HistoryDate).HasColumnType("datetime");

                entity.Property(e => e.HistoryDesc).HasMaxLength(250);

                entity.Property(e => e.HistoryTransDate).HasColumnType("datetime");

                entity.Property(e => e.IdBranch).HasColumnName("ID_Branch");

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdDesignation).HasColumnName("ID_Designation");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.IdLga)
                    .HasColumnName("ID_LGA")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IdNationality)
                    .HasColumnName("ID_Nationality")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdOccupation)
                    .HasColumnName("ID_Occupation")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.IdProduct)
                    .HasColumnName("ID_Product")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.IdSickness).HasColumnName("ID_Sickness");

                entity.Property(e => e.IdState)
                    .HasColumnName("ID_State")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Idcard)
                    .HasColumnName("IDCard")
                    .HasMaxLength(1);

                entity.Property(e => e.IdcardDate)
                    .HasColumnName("IDCardDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdcardTotal)
                    .HasColumnName("IDCardTotal")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ImageFileName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IncDate).HasColumnType("datetime");

                entity.Property(e => e.Inclusion).HasMaxLength(1);

                entity.Property(e => e.JobLevel)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MartialStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.NextOfKin)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StaffNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tdate).HasColumnType("date");

                entity.Property(e => e.TerminalDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TypeMove).HasMaxLength(1);

                entity.Property(e => e.Usermove)
                    .HasColumnName("usermove")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EndorseTbl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("endorse_tbl");

                entity.Property(e => e.Class)
                    .HasColumnName("class")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Groupno).HasColumnName("groupno");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.Premium)
                    .HasColumnName("premium")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Enollementlist>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("enollementlist");

                entity.Property(e => e.Checking).HasColumnName("checking");

                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.PhoneNo).HasMaxLength(50);

                entity.Property(e => e.Plan)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.StaffNo).HasMaxLength(10);

                entity.Property(e => e.Surname).HasMaxLength(30);

                entity.Property(e => e.Tdate).HasColumnType("date");

                entity.Property(e => e.TempEnrolleeNo).HasColumnName("Temp. EnrolleeNo");

                entity.Property(e => e.Vetted).HasColumnName("vetted");
            });

            modelBuilder.Entity<EnrolleeLogin>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Enrollee_Login");

                entity.Property(e => e.Address01)
                    .HasColumnName("Address_01")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Address02)
                    .HasColumnName("Address_02")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.BloodGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeProvfrom).HasMaxLength(60);

                entity.Property(e => e.Checking).HasColumnName("checking");

                entity.Property(e => e.ChgDate).HasColumnType("datetime");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentIdCapitation)
                    .HasColumnName("Current_ID_Capitation")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrentIdPolicy)
                    .HasColumnName("Current_ID_Policy")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentIdPremiun)
                    .HasColumnName("Current_ID_Premiun")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DateOfBrith).HasColumnType("datetime");

                entity.Property(e => e.DateReceived).HasColumnType("datetime");

                entity.Property(e => e.Datemove).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Encounter)
                    .HasColumnName("encounter")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Genotype)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Gsmnumber)
                    .HasColumnName("GSMNumber")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.HistoryDate).HasColumnType("datetime");

                entity.Property(e => e.HistoryDesc).HasMaxLength(250);

                entity.Property(e => e.HistoryTransDate).HasColumnType("datetime");

                entity.Property(e => e.IdBranch).HasColumnName("ID_Branch");

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdDesignation).HasColumnName("ID_Designation");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.IdLga)
                    .HasColumnName("ID_LGA")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IdNationality)
                    .HasColumnName("ID_Nationality")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdOccupation)
                    .HasColumnName("ID_Occupation")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.IdProduct)
                    .HasColumnName("ID_Product")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.IdSickness).HasColumnName("ID_Sickness");

                entity.Property(e => e.IdState)
                    .HasColumnName("ID_State")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Idcard)
                    .HasColumnName("IDCard")
                    .HasMaxLength(1);

                entity.Property(e => e.IdcardDate)
                    .HasColumnName("IDCardDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdcardTotal)
                    .HasColumnName("IDCardTotal")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ImageFileName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Imgfile)
                    .HasColumnName("imgfile")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IncDate).HasColumnType("datetime");

                entity.Property(e => e.Inclusion).HasMaxLength(1);

                entity.Property(e => e.JobLevel)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LastLogin)
                    .HasColumnName("Last_Login")
                    .HasColumnType("datetime");

                entity.Property(e => e.MartialStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NextOfKin)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sn).HasColumnName("sn");

                entity.Property(e => e.StaffNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tdate).HasColumnType("date");

                entity.Property(e => e.TerminalDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TypeMove).HasMaxLength(1);

                entity.Property(e => e.Usermove)
                    .HasColumnName("usermove")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EnrolleePortal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Enrollee_Portal");

                entity.Property(e => e.Encounter)
                    .HasColumnName("encounter")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.Imgfile)
                    .HasColumnName("imgfile")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LastLogin)
                    .HasColumnName("Last_Login")
                    .HasColumnType("datetime");

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ErrLogDetails>(entity =>
            {
                entity.HasKey(e => e.IdErrLogDtl)
                    .HasName("PK_ID_ErrLogDetails");

                entity.Property(e => e.IdErrLogDtl).HasColumnName("ID_ErrLogDtl");

                entity.Property(e => e.IdErrLogMst).HasColumnName("ID_ErrLogMst");

                entity.Property(e => e.Narration)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ErrLogMaster>(entity =>
            {
                entity.HasKey(e => e.IdErrLogMst);

                entity.Property(e => e.IdErrLogMst).HasColumnName("ID_ErrLogMst");

                entity.Property(e => e.Narration)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessedBy)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TransDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FeedBack>(entity =>
            {
                entity.HasKey(e => e.IdFeedBack);

                entity.Property(e => e.IdFeedBack).HasColumnName("ID_FeedBack");

                entity.Property(e => e.CapturedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FeedBack1)
                    .HasColumnName("FeedBack")
                    .HasColumnType("text");

                entity.Property(e => e.FeedBackDate).HasColumnType("datetime");

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdNextActionType)
                    .HasColumnName("ID_NextActionType")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NextActionDate).HasColumnType("datetime");

                entity.Property(e => e.TransDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FeedBackProvider>(entity =>
            {
                entity.HasKey(e => e.IdFeedBack);

                entity.Property(e => e.IdFeedBack).HasColumnName("ID_FeedBack");

                entity.Property(e => e.CapturedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FeedBackDate).HasColumnType("datetime");

                entity.Property(e => e.Feedback).HasColumnType("text");

                entity.Property(e => e.IdNextActionType)
                    .HasColumnName("ID_NextActionType")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.NextActiondate).HasColumnType("datetime");

                entity.Property(e => e.TransDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FirstCapRun>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AmtAll).HasColumnType("money");

                entity.Property(e => e.AmtBro).HasColumnType("money");

                entity.Property(e => e.AmtGol).HasColumnType("money");

                entity.Property(e => e.AmtSil).HasColumnType("money");

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdFirstCapRun)
                    .HasColumnName("ID_FirstCapRun")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<GeneralTb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GeneralTB");

                entity.Property(e => e.BP)
                    .HasColumnName("B/p")
                    .HasMaxLength(20);

                entity.Property(e => e.BloodGroup)
                    .HasColumnName("Blood Group")
                    .HasMaxLength(15);

                entity.Property(e => e.Bmi).HasColumnName("BMI");

                entity.Property(e => e.BmiInference)
                    .HasColumnName("bmi inference")
                    .HasMaxLength(50);

                entity.Property(e => e.BodyTemp).HasColumnName("Body Temp");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Genotype).HasMaxLength(15);

                entity.Property(e => e.PatientNumber)
                    .IsRequired()
                    .HasColumnName("PATIENT_NUMBER")
                    .HasMaxLength(30);

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasMaxLength(50);

                entity.Property(e => e.PulseRate).HasColumnName("Pulse rate");

                entity.Property(e => e.UpsizeTs)
                    .IsRequired()
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<GenotypeCodeTb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GenotypeCodeTB");

                entity.Property(e => e.GenotypeCode)
                    .HasColumnName("GENOTYPE_CODE")
                    .HasMaxLength(25);

                entity.Property(e => e.GenotypeDescription)
                    .HasColumnName("GENOTYPE_DESCRIPTION")
                    .HasMaxLength(20);

                entity.Property(e => e.SpecificMedication)
                    .HasColumnName("SPECIFIC_MEDICATION")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<Idcard>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IDCard");

                entity.Property(e => e.Address).HasMaxLength(90);

                entity.Property(e => e.Allergy).HasMaxLength(50);

                entity.Property(e => e.BloodG).HasMaxLength(25);

                entity.Property(e => e.Dob)
                    .HasColumnName("dob")
                    .HasColumnType("date");

                entity.Property(e => e.EmployeeNo).HasMaxLength(50);

                entity.Property(e => e.ExpDate).HasMaxLength(25);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Gt).HasMaxLength(25);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdIdcard)
                    .HasColumnName("ID_Idcard")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(30);

                entity.Property(e => e.OtherName).HasMaxLength(50);

                entity.Property(e => e.Photo).IsUnicode(false);

                entity.Property(e => e.Photo2).HasColumnType("image");

                entity.Property(e => e.Product).HasMaxLength(45);

                entity.Property(e => e.ProviderA1).HasMaxLength(60);

                entity.Property(e => e.ProviderA2).HasMaxLength(60);

                entity.Property(e => e.ProviderN).HasMaxLength(50);

                entity.Property(e => e.Sex).HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(20);

                entity.Property(e => e.Surname).HasMaxLength(50);
            });

            modelBuilder.Entity<Idcard1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IDCard1");

                entity.Property(e => e.Address).HasMaxLength(90);

                entity.Property(e => e.EmployeeNo).HasMaxLength(50);

                entity.Property(e => e.ExpDate).HasMaxLength(25);

                entity.Property(e => e.IdIdcard)
                    .HasColumnName("ID_Idcard")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(30);

                entity.Property(e => e.Photo).HasColumnType("image");

                entity.Property(e => e.Product).HasMaxLength(20);

                entity.Property(e => e.State).HasMaxLength(20);
            });

            modelBuilder.Entity<IdcardRpt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IDCardRPT");

                entity.Property(e => e.CurrentIdPolicy)
                    .HasColumnName("Current_ID_Policy")
                    .HasMaxLength(20);

                entity.Property(e => e.DateOfBrith).HasColumnType("datetime");

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("ID_Product")
                    .HasMaxLength(6);

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.Idcard)
                    .HasColumnName("IDCard")
                    .HasMaxLength(1);

                entity.Property(e => e.IdcardDate)
                    .HasColumnName("IDCardDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdcardTotal).HasColumnName("IDCardTotal");

                entity.Property(e => e.ImageFileName).HasMaxLength(150);

                entity.Property(e => e.Sbu).HasColumnName("SBU");

                entity.Property(e => e.SbuDes)
                    .HasColumnName("SBU_DES")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Sex).HasMaxLength(1);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<IndBenefits>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IND_BENEFITS");

                entity.Property(e => e.Amt).HasColumnName("AMT");

                entity.Property(e => e.Bronze)
                    .HasColumnName("BRONZE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bronzel).HasColumnName("BRONZEL");

                entity.Property(e => e.Count).HasColumnName("COUNT");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Essential)
                    .HasColumnName("ESSENTIAL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Essentiall).HasColumnName("ESSENTIALL");

                entity.Property(e => e.Gold)
                    .HasColumnName("GOLD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Goldl).HasColumnName("GOLDL");

                entity.Property(e => e.Platinium)
                    .HasColumnName("PLATINIUM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Platiniuml).HasColumnName("PLATINIUML");

                entity.Property(e => e.Silver)
                    .HasColumnName("SILVER")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Silverl).HasColumnName("SILVERL");

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Insured>(entity =>
            {
                entity.HasKey(e => e.IdInsured);

                entity.Property(e => e.IdInsured).HasColumnName("ID_Insured");

                entity.Property(e => e.CapAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.PolicyNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PrmAmount).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<InsuredProvider>(entity =>
            {
                entity.HasKey(e => e.IdInsuredprovider);

                entity.Property(e => e.IdInsuredprovider).HasColumnName("ID_Insuredprovider");

                entity.Property(e => e.BeginDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.IdInsured).HasColumnName("ID_insured");

                entity.Property(e => e.IdProvider).HasColumnName("ID_provider");

                entity.Property(e => e.PolicyNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdInsuredNavigation)
                    .WithMany(p => p.InsuredProvider)
                    .HasForeignKey(d => d.IdInsured)
                    .HasConstraintName("FK_InsuredProvider_Insured");
            });

            modelBuilder.Entity<InvestigationTb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("InvestigationTB");

                entity.Property(e => e.Code).ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Jobposition>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Lgarea>(entity =>
            {
                entity.HasKey(e => e.IdLga);

                entity.ToTable("LGArea");

                entity.HasIndex(e => e.LgArea1)
                    .HasName("Key_LGArea_Lg_Area");

                entity.Property(e => e.IdLga)
                    .HasColumnName("ID_LGA")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdState)
                    .IsRequired()
                    .HasColumnName("ID_State")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.LgArea1)
                    .IsRequired()
                    .HasColumnName("LG_Area")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Limitband>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("limitband");

                entity.Property(e => e.Band)
                    .HasColumnName("band")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LocationTb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("locationTB");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Logging>(entity =>
            {
                entity.HasKey(e => e.InternalId);

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.ActionDone)
                    .HasColumnName("Action_Done")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Audit).HasColumnType("datetime");

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Pk)
                    .HasColumnName("PK")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProcedureName)
                    .HasColumnName("Procedure_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SessionId)
                    .HasColumnName("SessionID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasColumnName("Table_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LoginTb>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("LoginTB");

                entity.Property(e => e.UserId)
                    .HasColumnName("userId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Accesslevel)
                    .HasColumnName("accesslevel")
                    .HasMaxLength(1);

                entity.Property(e => e.Administration)
                    .HasColumnName("administration")
                    .HasMaxLength(1);

                entity.Property(e => e.Capitation)
                    .HasColumnName("capitation")
                    .HasMaxLength(1);

                entity.Property(e => e.CapitationPro).HasMaxLength(1);

                entity.Property(e => e.Caprpt).HasMaxLength(1);

                entity.Property(e => e.ChangeProv)
                    .HasColumnName("changeProv")
                    .HasMaxLength(1);

                entity.Property(e => e.Claimhead)
                    .HasColumnName("claimhead")
                    .HasMaxLength(1);

                entity.Property(e => e.ClaimsPro).HasMaxLength(1);

                entity.Property(e => e.Claimscode).HasColumnName("claimscode");

                entity.Property(e => e.Company).HasMaxLength(1);

                entity.Property(e => e.Companyreg).HasMaxLength(1);

                entity.Property(e => e.Deactivecompany)
                    .HasColumnName("deactivecompany")
                    .HasMaxLength(1);

                entity.Property(e => e.Deactiveenrollee)
                    .HasColumnName("deactiveenrollee")
                    .HasMaxLength(1);

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Employee).HasMaxLength(1);

                entity.Property(e => e.Endorse)
                    .HasColumnName("endorse")
                    .HasMaxLength(1);

                entity.Property(e => e.Enrollereg).HasMaxLength(1);

                entity.Property(e => e.History).HasMaxLength(1);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.Idreset)
                    .HasColumnName("idreset")
                    .HasMaxLength(1);

                entity.Property(e => e.Marketing)
                    .HasColumnName("marketing")
                    .HasMaxLength(1);

                entity.Property(e => e.Nhiscappro)
                    .HasColumnName("NHIScappro")
                    .HasMaxLength(1);

                entity.Property(e => e.Nhisrpt)
                    .HasColumnName("NHISrpt")
                    .HasMaxLength(1);

                entity.Property(e => e.Others).HasMaxLength(1);

                entity.Property(e => e.Others1)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Payment)
                    .HasColumnName("payment")
                    .HasMaxLength(1);

                entity.Property(e => e.Paymentrpts).HasMaxLength(1);

                entity.Property(e => e.Paymentsub).HasMaxLength(1);

                entity.Property(e => e.Policyreg).HasMaxLength(1);

                entity.Property(e => e.Primary).HasMaxLength(1);

                entity.Property(e => e.Provider)
                    .HasColumnName("provider")
                    .HasMaxLength(1);

                entity.Property(e => e.Providerreg).HasMaxLength(1);

                entity.Property(e => e.Reactivecompany)
                    .HasColumnName("reactivecompany")
                    .HasMaxLength(1);

                entity.Property(e => e.Reactiveenrollee)
                    .HasColumnName("reactiveenrollee")
                    .HasMaxLength(1);

                entity.Property(e => e.Registration)
                    .HasColumnName("registration")
                    .HasMaxLength(1);

                entity.Property(e => e.Registrationrpt)
                    .HasColumnName("registrationrpt")
                    .HasMaxLength(1);

                entity.Property(e => e.Reports)
                    .HasColumnName("reports")
                    .HasMaxLength(1);

                entity.Property(e => e.Scheme).HasMaxLength(1);

                entity.Property(e => e.Secondary).HasMaxLength(1);

                entity.Property(e => e.Setupcodes)
                    .HasColumnName("setupcodes")
                    .HasMaxLength(1);

                entity.Property(e => e.ShipT)
                    .HasColumnName("shipT")
                    .HasMaxLength(1);

                entity.Property(e => e.Specialist).HasMaxLength(1);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Usercompany)
                    .HasColumnName("usercompany")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Userpassword)
                    .HasColumnName("userpassword")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Userprovider)
                    .HasColumnName("userprovider")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Utility)
                    .HasColumnName("utility")
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<Mailconnection>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mailconnection");

                entity.Property(e => e.Billmth).HasColumnName("billmth");

                entity.Property(e => e.Capcond).HasColumnName("capcond");

                entity.Property(e => e.Capdays).HasColumnName("capdays");

                entity.Property(e => e.ChgprovSms)
                    .HasColumnName("chgprov_sms")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DeactivateSms)
                    .HasColumnName("deactivate_sms")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Deprejectsms)
                    .HasColumnName("deprejectsms")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DomainName)
                    .HasColumnName("Domain_Name")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Enrolleenocode)
                    .HasColumnName("enrolleenocode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Groupage).HasColumnName("groupage");

                entity.Property(e => e.Groupdepage).HasColumnName("groupdepage");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Maxdepage).HasColumnName("maxdepage");

                entity.Property(e => e.Maxempage).HasColumnName("maxempage");

                entity.Property(e => e.NewRegSms)
                    .HasColumnName("new_reg_sms")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Prefix)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Pwd)
                    .HasColumnName("pwd")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rejectsms)
                    .HasColumnName("rejectsms")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Retaildepage).HasColumnName("retaildepage");

                entity.Property(e => e.Sender)
                    .HasColumnName("sender")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SenderName)
                    .HasColumnName("Sender_Name")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SenderPassword)
                    .HasColumnName("Sender_Password")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Smsname)
                    .HasColumnName("smsname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Smspwd)
                    .HasColumnName("smspwd")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Smsusr)
                    .HasColumnName("smsusr")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SmtpClientHost)
                    .HasColumnName("Smtp_Client_Host")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Mailsetup>(entity =>
            {
                entity.ToTable("mailsetup");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Capdays).HasColumnName("capdays");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pwd)
                    .HasColumnName("pwd")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MaritalStatusCodeTb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MaritalStatusCodeTB");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasMaxLength(15);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<NewDiagnosis>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(255);

                entity.Property(e => e.Diagnosis).HasMaxLength(255);

                entity.Property(e => e.Sno)
                    .HasColumnName("sno")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<NewDiagnosis5>(entity =>
            {
                entity.HasKey(e => e.Sno);

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Diagnosis)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NhisAttendance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NHIS_Attendance");

                entity.Property(e => e.AttId)
                    .HasColumnName("Att_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Diagnosis).HasMaxLength(50);

                entity.Property(e => e.Drugs).HasMaxLength(50);

                entity.Property(e => e.EmployeeNo).HasMaxLength(50);

                entity.Property(e => e.FormCode)
                    .HasColumnName("Form_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.Investigation).HasMaxLength(50);

                entity.Property(e => e.ProviderId)
                    .HasColumnName("Provider_Id")
                    .HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(50);

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.Treatment).HasMaxLength(60);
            });

            modelBuilder.Entity<NhisClaimsTb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NHIS_ClaimsTB");

                entity.Property(e => e.ConsultationFee).HasColumnType("money");

                entity.Property(e => e.DateofBirth).HasColumnType("datetime");

                entity.Property(e => e.Diagnosis).HasMaxLength(200);

                entity.Property(e => e.DispensingDate).HasColumnType("datetime");

                entity.Property(e => e.Drname)
                    .HasColumnName("DRNAME")
                    .HasMaxLength(150);

                entity.Property(e => e.EmployeeName).HasMaxLength(150);

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Formno)
                    .HasColumnName("formno")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdCompany)
                    .HasColumnName("ID_Company")
                    .HasMaxLength(50);

                entity.Property(e => e.IdProvider)
                    .HasColumnName("ID_Provider")
                    .HasMaxLength(50);

                entity.Property(e => e.Investigation)
                    .HasColumnName("investigation")
                    .HasMaxLength(50);

                entity.Property(e => e.PharmacistName)
                    .HasColumnName("pharmacistName")
                    .HasMaxLength(150);

                entity.Property(e => e.Ppcode)
                    .HasColumnName("PPcode")
                    .HasMaxLength(50);

                entity.Property(e => e.Ppname)
                    .HasColumnName("ppname")
                    .HasMaxLength(200);

                entity.Property(e => e.Procedure).HasColumnType("ntext");

                entity.Property(e => e.ProviderName).HasMaxLength(170);

                entity.Property(e => e.Sex)
                    .HasColumnName("SEX")
                    .HasMaxLength(50);

                entity.Property(e => e.TreatmentDate).HasColumnType("datetime");

                entity.Property(e => e.UpsizeTs)
                    .IsRequired()
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<NhisDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NHIS_Detail");

                entity.Property(e => e.FamilyCode).HasMaxLength(50);

                entity.Property(e => e.Hcpcode)
                    .HasColumnName("HCPCode")
                    .HasMaxLength(55);

                entity.Property(e => e.Indcode)
                    .HasColumnName("indcode")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Indcode1)
                    .HasColumnName("indcode1")
                    .HasMaxLength(50);

                entity.Property(e => e.Pdob).HasColumnType("date");

                entity.Property(e => e.Plcode).HasMaxLength(50);

                entity.Property(e => e.Pothername).HasMaxLength(50);

                entity.Property(e => e.Psex)
                    .HasColumnName("PSex")
                    .HasMaxLength(50);

                entity.Property(e => e.PstatusId)
                    .HasColumnName("PstatusID")
                    .HasMaxLength(50);

                entity.Property(e => e.Pstatusname).HasMaxLength(50);

                entity.Property(e => e.Psurname)
                    .HasColumnName("PSurname")
                    .HasMaxLength(50);

                entity.Property(e => e.Qtr).HasColumnName("qtr");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<NhisHospD>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NHIS_Hosp_D");

                entity.Property(e => e.Hcpadd)
                    .HasColumnName("HCPAdd")
                    .HasMaxLength(150);

                entity.Property(e => e.Hcpcode)
                    .IsRequired()
                    .HasColumnName("HCPCode")
                    .HasMaxLength(150);

                entity.Property(e => e.State).HasMaxLength(50);
            });

            modelBuilder.Entity<NhisHospSum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NHIS_Hosp_Sum");

                entity.Property(e => e.Lst1).HasMaxLength(255);

                entity.Property(e => e.Lst2).HasMaxLength(255);

                entity.Property(e => e.Qtr).HasColumnName("qtr");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<Nhisclient>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NHISCLIENT");

                entity.Property(e => e.Addresses)
                    .HasColumnName("ADDRESSES")
                    .HasMaxLength(255);

                entity.Property(e => e.Addresses1)
                    .HasColumnName("ADDRESSES1")
                    .HasMaxLength(255);

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasColumnName("CONTACT")
                    .HasMaxLength(255);

                entity.Property(e => e.FedMinistriesParastatalsExtraMinisterialDepts)
                    .HasColumnName("FED# MINISTRIES/PARASTATALS/EXTRA-MINISTERIAL DEPTS")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthManagementOrganisations)
                    .HasColumnName("HEALTH MANAGEMENT ORGANISATIONS")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("S/No");
            });

            modelBuilder.Entity<Nhissum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NHISsum");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("notification");

                entity.Property(e => e.Insertdate)
                    .HasColumnName("insertdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Notification1)
                    .HasColumnName("notification")
                    .IsUnicode(false);

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Notification2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Insertdate)
                    .HasColumnName("insertdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Notification)
                    .HasColumnName("notification")
                    .IsUnicode(false);

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Notification3>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Insertdate)
                    .HasColumnName("insertdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Notification)
                    .HasColumnName("notification")
                    .IsUnicode(false);

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Notification6>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("notification6");

                entity.Property(e => e.Insertdate)
                    .HasColumnName("insertdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Notification)
                    .HasColumnName("notification")
                    .IsUnicode(false);

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Numbercheck>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");
            });

            modelBuilder.Entity<Occupation>(entity =>
            {
                entity.HasKey(e => e.IdOccupation);

                entity.Property(e => e.IdOccupation).HasColumnName("ID_Occupation");

                entity.Property(e => e.Occupation1)
                    .HasColumnName("Occupation")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PaymentModeTb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PaymentModeTB");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasMaxLength(1);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(13);
            });

            modelBuilder.Entity<Pcphist>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("pcphist");

                entity.Property(e => e.Classification).HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Diagnosis).HasMaxLength(200);

                entity.Property(e => e.EmployeeName).HasMaxLength(150);

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TreatmentDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PersonsBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Persons_Backup");

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgentCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BizLine)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BoardofDirectors)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CompCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyLogo)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DirectorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("EMailAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GlprmAcctNo)
                    .HasColumnName("GLPrmAcctNo")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.Gsmnumber)
                    .HasColumnName("GSMNumber")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany)
                    .HasColumnName("ID_Company")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdState)
                    .HasColumnName("ID_State")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.InitialPrdId)
                    .HasColumnName("InitialPrdID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.PhoneNumbers)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.WebsiteAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlanCategoryTb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PlanCategoryTB");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(15);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PlanType1Tb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PlanType1TB");

                entity.Property(e => e.PlanDescription)
                    .HasColumnName("PLAN_DESCRIPTION")
                    .HasMaxLength(50);

                entity.Property(e => e.PlanType)
                    .IsRequired()
                    .HasColumnName("PLAN_TYPE")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Policy>(entity =>
            {
                entity.HasKey(e => e.PolicyNo);

                entity.HasIndex(e => e.IdPolicy)
                    .HasName("Key_ID_Policy")
                    .IsUnique();

                entity.Property(e => e.PolicyNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgentCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AnnualPremium).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BeginDate).HasColumnType("datetime");

                entity.Property(e => e.CapitationRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Classification)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Climit)
                    .HasColumnName("CLimit")
                    .HasColumnType("money");

                entity.Property(e => e.Comments)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CommissionRate).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.GrossCapitation).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GrossClaims).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GrossDiscount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GrossFee4Service).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GrossPremium).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GrossReceipt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IdBizUnit)
                    .HasColumnName("ID_BizUnit")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdLocation)
                    .HasColumnName("ID_Location")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IdPolicy)
                    .HasColumnName("ID_Policy")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdProduct)
                    .HasColumnName("ID_Product")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IdProductLine)
                    .HasColumnName("ID_ProductLine")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.JobLevel)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Narration)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Premium).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PremiumAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TenorType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.HasOne(d => d.IdProductNavigation)
                    .WithMany(p => p.Policy)
                    .HasForeignKey(d => d.IdProduct)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Policy_Product");
            });

            modelBuilder.Entity<PolicyReschd>(entity =>
            {
                entity.HasKey(e => e.IdPolicyReschd);

                entity.Property(e => e.IdPolicyReschd).HasColumnName("ID_PolicyReschd");

                entity.Property(e => e.AgentCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BeginDate).HasColumnType("datetime");

                entity.Property(e => e.CapitationAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CapitationRate).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Comments)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CommissionRate).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.GrossCapitation).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GrossClaims).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GrossDiscount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GrossFee4Service).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GrossPremium).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GrossReceipt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("ID_Product")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.JobLevel)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Narration)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NewPolicyNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Premium).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Reason4Reschd)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.HasOne(d => d.IdProductNavigation)
                    .WithMany(p => p.PolicyReschd)
                    .HasForeignKey(d => d.IdProduct)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PolicyReschd_Product");
            });

            modelBuilder.Entity<PolicyUpdDetails>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Cap2Pay).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdPolicyUpdDetails)
                    .HasColumnName("ID_PolicyUpdDetails")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdPolicyUpdMaster).HasColumnName("ID_PolicyUpdMaster");

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.Prm2Pay).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<PolicyUpdMaster>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.CapAmt2Deduct).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CaseType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.IdPolicyUpdMaster).HasColumnName("ID_PolicyUpdMaster");

                entity.Property(e => e.IdReason).HasColumnName("ID_Reason");

                entity.Property(e => e.PolicyNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PrmAmt2Deduct).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReqAction)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PrdBenefits>(entity =>
            {
                entity.HasKey(e => e.IdBenefit);

                entity.Property(e => e.IdBenefit).HasColumnName("ID_Benefit");

                entity.Property(e => e.Comments)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdProduct)
                    .IsRequired()
                    .HasColumnName("ID_Product")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PrdBenefit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubmitDate).HasColumnType("date");
            });

            modelBuilder.Entity<PreEmployDetail>(entity =>
            {
                entity.HasKey(e => e.IdPreEmpDetail);

                entity.Property(e => e.IdPreEmpDetail).HasColumnName("ID_PreEmpDetail");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany)
                    .HasColumnName("ID_Company")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdPreEmpMaster).HasColumnName("ID_PreEmpMaster");

                entity.HasOne(d => d.IdPreEmpMasterNavigation)
                    .WithMany(p => p.PreEmployDetail)
                    .HasForeignKey(d => d.IdPreEmpMaster)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PreEmployDetail_PreEmployMaster");
            });

            modelBuilder.Entity<PreEmployMaster>(entity =>
            {
                entity.HasKey(e => e.IdPreEmpMaster);

                entity.Property(e => e.IdPreEmpMaster).HasColumnName("ID_PreEmpMaster");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CapturedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DebitAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.InvNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Narration)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.TransType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Preferences>(entity =>
            {
                entity.HasKey(e => e.IdPreferences)
                    .HasName("PK_KeyPreferencesID")
                    .IsClustered(false);

                entity.Property(e => e.IdPreferences).HasColumnName("ID_Preferences");

                entity.Property(e => e.Address01)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address02)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AmbulanceServAcctNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CapitationAcctNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimsAcctNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClinicRunAcctNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CommissionAcctNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCodeSpName)
                    .HasColumnName("CompanyCode_spName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPosition)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CoyRegCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultPayType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DependantNoSpName)
                    .HasColumnName("DependantNo_spName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnrolleeNoSpName)
                    .HasColumnName("EnrolleeNo_spName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FinYearBegin)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IdApplication)
                    .HasColumnName("ID_Application")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IdBizUnit)
                    .HasColumnName("ID_BizUnit")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IdLocation)
                    .HasColumnName("ID_Location")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IdProductLine)
                    .HasColumnName("ID_ProductLine")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IdState)
                    .HasColumnName("ID_State")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastCapDate).HasColumnType("datetime");

                entity.Property(e => e.LastCommDate).HasColumnType("datetime");

                entity.Property(e => e.MailType)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Money4LodgementAcctNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Money4PaymentAcctNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MoneyDatabaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nhiscode)
                    .HasColumnName("NHISCode")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Nhisfolder)
                    .HasColumnName("NHISFolder")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PayableAcctNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyCodeSpName)
                    .HasColumnName("PolicyCode_spName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Post2Gl).HasColumnName("Post2GL");

                entity.Property(e => e.Post2Mbk).HasColumnName("Post2MBk");

                entity.Property(e => e.PreEmployAcctNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PremiumAcctNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderCodeSpName)
                    .HasColumnName("ProviderCode_spName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReceivableAcctNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralAuthenSpName)
                    .HasColumnName("ReferralAuthen_spName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReimburseAcctNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReplyToAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SenderAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SenderName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Smtphost)
                    .HasColumnName("SMTPHost")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Smtpport)
                    .HasColumnName("SMTPPort")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SoftwareName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SwitchVal).HasColumnType("datetime");

                entity.Property(e => e.Telephone01)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone02)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Website)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WhtacctNo)
                    .HasColumnName("WHTAcctNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WorkingDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Premium>(entity =>
            {
                entity.HasKey(e => e.IdPremium);

                entity.Property(e => e.IdPremium).HasColumnName("ID_Premium");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmtSettled).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CallBackId).HasColumnName("CallBackID");

                entity.Property(e => e.ChqInvNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CrMemo).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.EmpAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GlpostDate)
                    .HasColumnName("GLPostDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdDeltaPlc).HasColumnName("ID_DeltaPlc");

                entity.Property(e => e.IdPolicy).HasColumnName("ID_Policy");

                entity.Property(e => e.IdPolicyUpdMaster).HasColumnName("ID_PolicyUpdMaster");

                entity.Property(e => e.Narration)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostedBy)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PrmAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PrmPymtId).HasColumnName("PrmPymtID");

                entity.Property(e => e.ReversalId).HasColumnName("ReversalID");

                entity.Property(e => e.TransType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.Property(e => e.VoucherNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PremiumDetail>(entity =>
            {
                entity.HasKey(e => e.IdPrmDetail);

                entity.Property(e => e.IdPrmDetail).HasColumnName("ID_PrmDetail");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.DebitPrmId).HasColumnName("DebitPrmID");

                entity.Property(e => e.PayPrmId).HasColumnName("PayPrmID");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PolicyNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PremiumHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Premium_History");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdPremium).HasColumnName("ID_Premium");

                entity.Property(e => e.IdPremiumHistory)
                    .HasColumnName("ID_Premium_History")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PayIdPremium).HasColumnName("Pay_ID_Premium");

                entity.Property(e => e.PolicyNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.ValueDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PretestMtb>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ChargesApproved).HasColumnType("money");

                entity.Property(e => e.ChargesSent).HasColumnType("money");

                entity.Property(e => e.ConsultancyDate).HasColumnType("datetime");

                entity.Property(e => e.Day).HasMaxLength(2);

                entity.Property(e => e.EmployeeName).HasMaxLength(150);

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Formno)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.Month)
                    .HasColumnName("month")
                    .HasMaxLength(2);

                entity.Property(e => e.Protype).HasMaxLength(3);

                entity.Property(e => e.TreatmentDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(50);

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<PretestMtbDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Adddt)
                    .HasColumnName("adddt")
                    .HasColumnType("date");

                entity.Property(e => e.ChargesApproved).HasColumnType("money");

                entity.Property(e => e.ChargesSent).HasColumnType("money");

                entity.Property(e => e.Classification).HasMaxLength(50);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.ConsultancyDate).HasColumnType("datetime");

                entity.Property(e => e.ConsultancyFee).HasColumnType("money");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Diagnosis).HasMaxLength(200);

                entity.Property(e => e.Disdt)
                    .HasColumnName("disdt")
                    .HasColumnType("date");

                entity.Property(e => e.EmployeeName).HasMaxLength(150);

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Formno)
                    .IsRequired()
                    .HasColumnName("formno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.Month).HasColumnName("month");

                entity.Property(e => e.Protype).HasMaxLength(3);

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Sno)
                    .HasColumnName("sno")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TreatmentDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(50);

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<PrivateSchemeImport>(entity =>
            {
                entity.HasKey(e => e.IdImport);

                entity.HasIndex(e => e.StaffNo)
                    .HasName("IX_PrivateSchemeImport")
                    .IsUnique();

                entity.Property(e => e.IdImport).HasColumnName("ID_Import");

                entity.Property(e => e.Address01)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Address02)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CompCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateReceived).HasColumnType("datetime");

                entity.Property(e => e.DateofBirth).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmpType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EnrolleeState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FamilyCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gsmnumber)
                    .HasColumnName("GSMNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("ID_Product")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Importfile)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.JobLevel)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LineNo).HasColumnName("Line_No");

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Relationship)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StaffNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.IdProduct)
                    .HasName("PK_PolicyType");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("ID_Product")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CapitationAcctNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CapitationAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimsAcctNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Classification)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CollectiveCover).HasDefaultValueSql("((0))");

                entity.Property(e => e.CommissionAcctNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InsuredClass)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('C')");

                entity.Property(e => e.Limit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MinFee4Serv).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MinPremium).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PayableAcctNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrdDocRepName)
                    .HasColumnName("PrdDoc_RepName")
                    .IsUnicode(false);

                entity.Property(e => e.PremCalcSpName)
                    .HasColumnName("PremCalc_spName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PremiumAcctNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceivableAcctNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ProspectiveProduct>(entity =>
            {
                entity.HasKey(e => e.IdProspectProduct);

                entity.Property(e => e.IdProspectProduct).HasColumnName("ID_ProspectProduct");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("ID_Product")
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.HasKey(e => e.IdProvider);

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Address01)
                    .HasColumnName("Address_01")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Address02)
                    .HasColumnName("Address_02")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Bandtype)
                    .HasColumnName("bandtype")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BankLocation)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BankSortCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CapitationFixed).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CapitationRate).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Email2)
                    .HasColumnName("email2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GlcapAcctNo)
                    .HasColumnName("GLCapAcctNo")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.GlclmAcctNo)
                    .HasColumnName("GLClmAcctNo")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.GrossCapitatn).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Gsmnumber)
                    .HasColumnName("GSMNumber")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Hnisnumber)
                    .HasColumnName("HNISNumber")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdBank)
                    .HasColumnName("ID_Bank")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IdCostLevel)
                    .HasColumnName("ID_CostLevel")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdDoctor).HasColumnName("ID_Doctor");

                entity.Property(e => e.IdLga)
                    .HasColumnName("ID_LGA")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IdSpecialty).HasColumnName("ID_Specialty");

                entity.Property(e => e.IdState)
                    .HasColumnName("ID_State")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.LinkCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.PhoneNumbers)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PictureFileName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PrvCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RefNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TmpPrvCode)
                    .HasColumnName("tmpPrvCode")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasMaxLength(1);

                entity.Property(e => e.WebsiteAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Provider1>(entity =>
            {
                entity.HasKey(e => e.IdProvider)
                    .HasName("PK_Provider_1");

                entity.HasIndex(e => e.ProviderName)
                    .HasName("Key_Provider_Name")
                    .IsUnique();

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Address01)
                    .HasColumnName("Address_01")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address02)
                    .HasColumnName("Address_02")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bandtype)
                    .HasColumnName("bandtype")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BankLocation)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BankSortCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CapitationFixed).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CapitationRate).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasColumnName("email2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GlcapAcctNo)
                    .HasColumnName("GLCapAcctNo")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.GlclmAcctNo)
                    .HasColumnName("GLClmAcctNo")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.GrossCapitatn).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Gsmnumber)
                    .HasColumnName("GSMNumber")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Hnisnumber)
                    .HasColumnName("HNISNumber")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdBank)
                    .HasColumnName("ID_Bank")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IdCostLevel)
                    .HasColumnName("ID_CostLevel")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdDoctor).HasColumnName("ID_Doctor");

                entity.Property(e => e.IdLga)
                    .HasColumnName("ID_LGA")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IdSpecialty).HasColumnName("ID_Specialty");

                entity.Property(e => e.IdState)
                    .HasColumnName("ID_State")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.LinkCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.PhoneNumbers)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PictureFileName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrvCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RefNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TmpPrvCode)
                    .HasColumnName("tmpPrvCode")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasMaxLength(1);

                entity.Property(e => e.WebsiteAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdSpecialtyNavigation)
                    .WithMany(p => p.Provider1)
                    .HasForeignKey(d => d.IdSpecialty)
                    .HasConstraintName("FK_Provider_Specialty");
            });

            modelBuilder.Entity<ProviderLogin>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Provider_Login");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Address01)
                    .HasColumnName("Address_01")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Address02)
                    .HasColumnName("Address_02")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Bandtype)
                    .HasColumnName("bandtype")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BankLocation)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BankSortCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CapitationFixed).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CapitationRate).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Email2)
                    .HasColumnName("email2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Encounter)
                    .HasColumnName("encounter")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GlcapAcctNo)
                    .HasColumnName("GLCapAcctNo")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.GlclmAcctNo)
                    .HasColumnName("GLClmAcctNo")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.GrossCapitatn).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Gsmnumber)
                    .HasColumnName("GSMNumber")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Hnisnumber)
                    .HasColumnName("HNISNumber")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdBank)
                    .HasColumnName("ID_Bank")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IdCostLevel)
                    .HasColumnName("ID_CostLevel")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdDoctor).HasColumnName("ID_Doctor");

                entity.Property(e => e.IdLga)
                    .HasColumnName("ID_LGA")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.IdSpecialty).HasColumnName("ID_Specialty");

                entity.Property(e => e.IdState)
                    .HasColumnName("ID_State")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Imgfile)
                    .HasColumnName("imgfile")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LastLogin)
                    .HasColumnName("Last_Login")
                    .HasColumnType("datetime");

                entity.Property(e => e.LinkCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.PhoneNumbers)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PictureFileName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Providercode)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.PrvCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RefNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Sn).HasColumnName("sn");

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TmpPrvCode)
                    .HasColumnName("tmpPrvCode")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasMaxLength(1);

                entity.Property(e => e.WebsiteAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProviderPortal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Provider_Portal");

                entity.Property(e => e.Encounter)
                    .HasColumnName("encounter")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.Imgfile)
                    .HasColumnName("imgfile")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LastLogin)
                    .HasColumnName("Last_Login")
                    .HasColumnType("datetime");

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ProviderPp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProviderPP");

                entity.Property(e => e.Address01)
                    .HasColumnName("Address_01")
                    .HasMaxLength(50);

                entity.Property(e => e.Address02)
                    .HasColumnName("Address_02")
                    .HasMaxLength(50);

                entity.Property(e => e.Bandtype)
                    .HasColumnName("bandtype")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Email2)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IdDoctor).HasColumnName("ID_Doctor");

                entity.Property(e => e.IdLga)
                    .HasColumnName("ID_LGA")
                    .HasMaxLength(3);

                entity.Property(e => e.IdProvider)
                    .HasColumnName("ID_Provider")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdState)
                    .HasColumnName("ID_State")
                    .HasMaxLength(3);

                entity.Property(e => e.PhoneNumbers).HasMaxLength(50);

                entity.Property(e => e.ProviderName).HasMaxLength(35);
            });

            modelBuilder.Entity<ProviderReturns>(entity =>
            {
                entity.HasKey(e => e.IdReturns);

                entity.Property(e => e.IdReturns).HasColumnName("ID_Returns");

                entity.Property(e => e.AdmissionDate).HasColumnType("datetime");

                entity.Property(e => e.ApprovedAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.BillCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CapturedBy)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DischargeDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorNotes).HasColumnType("text");

                entity.Property(e => e.Fee4Serv)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GlpostDate)
                    .HasColumnName("GLPostDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdDiagnosis).HasColumnName("ID_Diagnosis");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.IdReason).HasColumnName("ID_Reason");

                entity.Property(e => e.IdReferral).HasColumnName("ID_Referral");

                entity.Property(e => e.IdSpeciality4Claims).HasColumnName("ID_Speciality4Claims");

                entity.Property(e => e.IdTreatmentResult)
                    .HasColumnName("ID_TreatmentResult")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.OverrideBy)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OverrideDate).HasColumnType("datetime");

                entity.Property(e => e.PatientName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PersonTreated)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e.PolicyNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostedBy)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderBill).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrvRetId).HasColumnName("PrvRetID");

                entity.Property(e => e.Reason)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Referral)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReqDtlId).HasColumnName("ReqDtlID");

                entity.Property(e => e.ReqMstId).HasColumnName("ReqMstID");

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TransType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TreatmentDate).HasColumnType("datetime");

                entity.Property(e => e.VoucherNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTreatmentResultNavigation)
                    .WithMany(p => p.ProviderReturns)
                    .HasForeignKey(d => d.IdTreatmentResult)
                    .HasConstraintName("FK_ProviderReturns_TreatmentResult");
            });

            modelBuilder.Entity<ProviderReturnsMaster>(entity =>
            {
                entity.HasKey(e => e.IdProvRtnMaster);

                entity.HasIndex(e => e.BillCode)
                    .HasName("IX_ProviderReturnsMaster")
                    .IsUnique();

                entity.Property(e => e.BillCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillPeriodBegin).HasColumnType("datetime");

                entity.Property(e => e.BillPeriodEnd).HasColumnType("datetime");

                entity.Property(e => e.CaptureDate).HasColumnType("datetime");

                entity.Property(e => e.CapturedBy)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Classification)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EmpType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndResult)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdProvider).HasColumnName("Id_Provider");

                entity.Property(e => e.Narration)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalApproved).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TransType)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProviderScp>(entity =>
            {
                entity.HasKey(e => e.IdProvider);

                entity.ToTable("ProviderSCP");

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.Address01)
                    .HasColumnName("Address_01")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address02)
                    .HasColumnName("Address_02")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bandtype)
                    .HasColumnName("bandtype")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdDoctor).HasColumnName("ID_Doctor");

                entity.Property(e => e.IdLga)
                    .HasColumnName("ID_LGA")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IdState)
                    .HasColumnName("ID_State")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumbers)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScpSpeciality)
                    .HasColumnName("SCP_Speciality")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ProviderSpecialty>(entity =>
            {
                entity.HasKey(e => e.IdProviderSpecialty);

                entity.Property(e => e.IdProviderSpecialty).HasColumnName("ID_ProviderSpecialty");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdAreaOfSpecialty).HasColumnName("ID_AreaOfSpecialty");

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");
            });

            modelBuilder.Entity<Providernhis>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PROVIDERNHIS");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Address01)
                    .HasColumnName("Address_01")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address02)
                    .HasColumnName("Address_02")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bandtype)
                    .HasColumnName("bandtype")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BankLocation)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BankSortCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CapitationFixed).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CapitationRate).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GlcapAcctNo)
                    .HasColumnName("GLCapAcctNo")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.GlclmAcctNo)
                    .HasColumnName("GLClmAcctNo")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.GrossCapitatn).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Gsmnumber)
                    .HasColumnName("GSMNumber")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Hnisnumber)
                    .HasColumnName("HNISNumber")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdBank)
                    .HasColumnName("ID_Bank")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IdCostLevel)
                    .HasColumnName("ID_CostLevel")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdDoctor).HasColumnName("ID_Doctor");

                entity.Property(e => e.IdLga)
                    .HasColumnName("ID_LGA")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IdProvider)
                    .HasColumnName("ID_Provider")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdSpecialty).HasColumnName("ID_Specialty");

                entity.Property(e => e.IdState)
                    .HasColumnName("ID_State")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.LinkCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.PhoneNumbers)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PictureFileName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrvCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RefNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TmpPrvCode)
                    .HasColumnName("tmpPrvCode")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasMaxLength(1);

                entity.Property(e => e.WebsiteAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Provlist>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PROVLIST");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("ID_Product")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.ImageFileName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Query>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AddDiagnosis)
                    .HasColumnName("add_diagnosis")
                    .HasMaxLength(500);

                entity.Property(e => e.Adddt)
                    .HasColumnName("adddt")
                    .HasColumnType("date");

                entity.Property(e => e.ChargesApproved).HasColumnType("money");

                entity.Property(e => e.ChargesSent).HasColumnType("money");

                entity.Property(e => e.Classification).HasMaxLength(100);

                entity.Property(e => e.Comment).HasColumnType("text");

                entity.Property(e => e.ConsultancyDate).HasColumnType("datetime2(3)");

                entity.Property(e => e.ConsultancyFee).HasColumnType("money");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Diagnosis).HasMaxLength(200);

                entity.Property(e => e.Disdt)
                    .HasColumnName("disdt")
                    .HasColumnType("date");

                entity.Property(e => e.EmployeeName).HasMaxLength(150);

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Formno)
                    .IsRequired()
                    .HasColumnName("formno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("ID_Product")
                    .HasMaxLength(50);

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.Month).HasColumnName("month");

                entity.Property(e => e.Procedure).HasColumnType("ntext");

                entity.Property(e => e.Protype).HasMaxLength(3);

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.TreatmentDate).HasColumnType("datetime2(3)");

                entity.Property(e => e.UserId).HasMaxLength(50);

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<Reasons>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Capitated)
                    .HasColumnName("capitated")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Reasons1)
                    .HasColumnName("REASONS")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ReferralReason>(entity =>
            {
                entity.HasKey(e => e.IdReferralReason);

                entity.Property(e => e.IdReferralReason).HasColumnName("ID_ReferralReason");

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralReason1)
                    .HasColumnName("ReferralReason")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Referrals>(entity =>
            {
                entity.HasKey(e => e.IdReferral);

                entity.Property(e => e.IdReferral).HasColumnName("ID_Referral");

                entity.Property(e => e.AuthorizationNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CallerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CapturedBy)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdDiagnosis).HasColumnName("ID_Diagnosis");

                entity.Property(e => e.IdLocation)
                    .HasColumnName("ID_Location")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.IdPrvReferred).HasColumnName("ID_PrvReferred");

                entity.Property(e => e.IdReferralReason).HasColumnName("ID_ReferralReason");

                entity.Property(e => e.IdReturns).HasColumnName("ID_Returns");

                entity.Property(e => e.Investigations)
                    .HasColumnName("investigations")
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.PatientName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PersonTreated)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PolicyNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReferredBy)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReferredDate).HasColumnType("datetime");

                entity.Property(e => e.RequestDate).HasColumnType("datetime");

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Reimburse>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("reimburse");

                entity.Property(e => e.Coyname)
                    .HasColumnName("coyname")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ddate).HasColumnType("date");

                entity.Property(e => e.Diag)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Ecase)
                    .HasColumnName("ecase")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnrolleeId)
                    .HasColumnName("enrolleeID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Formno)
                    .HasColumnName("formno")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Hosp)
                    .HasColumnName("hosp")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Inform)
                    .HasColumnName("inform")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ndate).HasColumnType("date");

                entity.Property(e => e.Pp)
                    .HasColumnName("pp")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Qinform)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .IsUnicode(false);

                entity.Property(e => e.Vdate).HasColumnType("date");
            });

            modelBuilder.Entity<ReimburseMtb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("reimburseMtb");

                entity.Property(e => e.ChargesApproved).HasColumnType("money");

                entity.Property(e => e.ChargesSent).HasColumnType("money");

                entity.Property(e => e.ConsultancyDate).HasColumnType("datetime");

                entity.Property(e => e.Day).HasMaxLength(2);

                entity.Property(e => e.EmployeeName).HasMaxLength(150);

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Formno)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.Month)
                    .HasColumnName("month")
                    .HasMaxLength(2);

                entity.Property(e => e.Protype).HasMaxLength(3);

                entity.Property(e => e.TreatmentDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(50);

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<ReimburseMtbDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("reimburseMtbDetail");

                entity.Property(e => e.Adddt)
                    .HasColumnName("adddt")
                    .HasColumnType("date");

                entity.Property(e => e.ChargesApproved).HasColumnType("money");

                entity.Property(e => e.ChargesSent).HasColumnType("money");

                entity.Property(e => e.Classification).HasMaxLength(50);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.ConsultancyDate).HasColumnType("datetime");

                entity.Property(e => e.ConsultancyFee).HasColumnType("money");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Diagnosis).HasMaxLength(200);

                entity.Property(e => e.Disdt)
                    .HasColumnName("disdt")
                    .HasColumnType("date");

                entity.Property(e => e.EmployeeName).HasMaxLength(150);

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Formno)
                    .IsRequired()
                    .HasColumnName("formno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.Month).HasColumnName("month");

                entity.Property(e => e.Protype).HasMaxLength(3);

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Sno)
                    .HasColumnName("sno")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TreatmentDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(50);

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<Reimbursetb>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Coyname)
                    .HasColumnName("coyname")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ddate).HasColumnType("date");

                entity.Property(e => e.Diag)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Ecase)
                    .HasColumnName("ecase")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnrolleeId)
                    .HasColumnName("enrolleeID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Formno)
                    .HasColumnName("formno")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Hosp)
                    .HasColumnName("hosp")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Inform)
                    .HasColumnName("inform")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ndate).HasColumnType("date");

                entity.Property(e => e.Pp)
                    .HasColumnName("pp")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Qinform)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .IsUnicode(false);

                entity.Property(e => e.Treated)
                    .HasColumnName("treated")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Vdate).HasColumnType("date");
            });

            modelBuilder.Entity<RelationshipTb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RelationshipTB");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(5);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ReligionTb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ReligionTB");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(15);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<RequisitionDetails>(entity =>
            {
                entity.HasKey(e => e.IdReqDetails)
                    .HasName("PK_ReqDetails");

                entity.Property(e => e.IdReqDetails).HasColumnName("ID_ReqDetails");

                entity.Property(e => e.Amount2Pay).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ChqInvNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GlpostDate)
                    .HasColumnName("GLPostDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCallBack).HasColumnName("ID_CallBack");

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.IdReqMaster).HasColumnName("ID_ReqMaster");

                entity.Property(e => e.Narration)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PostedBy)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessedBy)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TransType)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.Property(e => e.VoucherNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RequisitionMaster>(entity =>
            {
                entity.HasKey(e => e.IdReqMaster);

                entity.Property(e => e.IdReqMaster).HasColumnName("ID_ReqMaster");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Narration)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessedBy)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.ValueDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<RptAttRatio>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Idcode).HasColumnName("IDcode");

                entity.Property(e => e.Iddesc)
                    .HasColumnName("IDdesc")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<RptAuthcodeTrans>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rptAuthcodeTrans");

                entity.Property(e => e.AuthBy).HasMaxLength(50);

                entity.Property(e => e.Authcode)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Claim)
                    .HasColumnName("claim")
                    .HasMaxLength(1);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Diagnosis).IsUnicode(false);

                entity.Property(e => e.Employeeid).HasMaxLength(20);

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.Provtype)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasMaxLength(30);
            });

            modelBuilder.Entity<RptCap>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("rpt_cap");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChqInvNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdBranch).HasColumnName("ID_Branch");

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Narration)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OtherName).HasMaxLength(30);

                entity.Property(e => e.PolicyNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Rtype)
                    .HasColumnName("RType")
                    .HasMaxLength(1);

                entity.Property(e => e.Sbu)
                    .HasColumnName("SBU")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Surname).HasMaxLength(30);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.Property(e => e.VoucherNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RptClaimsAtt>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AttId)
                    .HasColumnName("Att_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Company).HasMaxLength(50);

                entity.Property(e => e.Diagnosis).IsUnicode(false);

                entity.Property(e => e.Drugs).IsUnicode(false);

                entity.Property(e => e.EmployeeNo).HasMaxLength(50);

                entity.Property(e => e.Employeename).HasMaxLength(50);

                entity.Property(e => e.Investigation).IsUnicode(false);

                entity.Property(e => e.Provider).HasMaxLength(50);

                entity.Property(e => e.ProviderId)
                    .HasColumnName("Provider_Id")
                    .HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(150);

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.Treatment).IsUnicode(false);
            });

            modelBuilder.Entity<RptNhisHospSum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rptNHIS_Hosp_Sum");

                entity.Property(e => e.Lst1).HasMaxLength(255);

                entity.Property(e => e.Lst2).HasMaxLength(255);

                entity.Property(e => e.Qtr).HasColumnName("qtr");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<RptNhisdetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rptNHISdetails");

                entity.Property(e => e.FamilyCode).HasMaxLength(50);

                entity.Property(e => e.Hcpcode)
                    .HasColumnName("HCPCode")
                    .HasMaxLength(55);

                entity.Property(e => e.Indcode).HasColumnName("indcode");

                entity.Property(e => e.Indcode1)
                    .HasColumnName("indcode1")
                    .HasMaxLength(50);

                entity.Property(e => e.Pdob).HasColumnType("date");

                entity.Property(e => e.Plcode).HasMaxLength(50);

                entity.Property(e => e.Pothername).HasMaxLength(50);

                entity.Property(e => e.Psex)
                    .HasColumnName("PSex")
                    .HasMaxLength(50);

                entity.Property(e => e.PstatusId)
                    .HasColumnName("PstatusID")
                    .HasMaxLength(50);

                entity.Property(e => e.Pstatusname).HasMaxLength(50);

                entity.Property(e => e.Psurname)
                    .HasColumnName("PSurname")
                    .HasMaxLength(50);

                entity.Property(e => e.Qtr).HasColumnName("qtr");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<RptNhissum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rptNHISSum");

                entity.Property(e => e.Lst1).HasMaxLength(255);

                entity.Property(e => e.Lst2).HasMaxLength(255);

                entity.Property(e => e.Qtr).HasColumnName("qtr");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<RptReceipt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rptReceipt");

                entity.Property(e => e.AmtPaid).HasColumnType("money");

                entity.Property(e => e.Bank).HasMaxLength(50);

                entity.Property(e => e.Begindt)
                    .HasColumnName("begindt")
                    .HasColumnType("date");

                entity.Property(e => e.BillType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ChequeNo).HasMaxLength(20);

                entity.Property(e => e.CompanyCode).HasMaxLength(10);

                entity.Property(e => e.CompanyName).HasMaxLength(60);

                entity.Property(e => e.EmployeeNo).HasMaxLength(50);

                entity.Property(e => e.Enddt)
                    .HasColumnName("enddt")
                    .HasColumnType("date");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModeOfPayment).HasMaxLength(10);

                entity.Property(e => e.PayId).HasColumnName("Pay_Id");

                entity.Property(e => e.ReceiptNo).HasMaxLength(15);

                entity.Property(e => e.Remark).HasColumnType("ntext");

                entity.Property(e => e.Transdate).HasColumnType("date");
            });

            modelBuilder.Entity<Rptauth>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rptauth");

                entity.Property(e => e.Employeeno)
                    .HasColumnName("employeeno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Empname)
                    .HasColumnName("empname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Empsurname)
                    .HasColumnName("empsurname")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Rptcapitation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RPTcapitation");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ApprovedBy).HasMaxLength(20);

                entity.Property(e => e.ChqInvNo).HasMaxLength(10);

                entity.Property(e => e.EmployeeNo).HasMaxLength(30);

                entity.Property(e => e.IdCapitation)
                    .HasColumnName("ID_capitation")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.Narration).HasMaxLength(50);

                entity.Property(e => e.OtherName).HasMaxLength(30);

                entity.Property(e => e.PolicyNo).HasMaxLength(20);

                entity.Property(e => e.Sbu).HasColumnName("sbu");

                entity.Property(e => e.Sex).HasMaxLength(10);

                entity.Property(e => e.Surname).HasMaxLength(30);

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.Property(e => e.ValueDate).HasColumnType("date");

                entity.Property(e => e.VoucherNo).HasMaxLength(10);
            });

            modelBuilder.Entity<RptclaimsMtb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RPTClaimsMTB");

                entity.Property(e => e.AddDiagnosis)
                    .HasColumnName("add_diagnosis")
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Adddt)
                    .HasColumnName("adddt")
                    .HasColumnType("date");

                entity.Property(e => e.ChargesApproved).HasColumnType("money");

                entity.Property(e => e.ChargesSent).HasColumnType("money");

                entity.Property(e => e.Classification).HasMaxLength(100);

                entity.Property(e => e.Comment).HasMaxLength(250);

                entity.Property(e => e.ConsultancyDate).HasColumnType("datetime");

                entity.Property(e => e.ConsultancyFee).HasColumnType("money");

                entity.Property(e => e.Day).HasMaxLength(2);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Diagnosis).HasMaxLength(200);

                entity.Property(e => e.Disdt)
                    .HasColumnName("disdt")
                    .HasColumnType("date");

                entity.Property(e => e.EmployeeName).HasMaxLength(150);

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Formno)
                    .IsRequired()
                    .HasColumnName("formno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("ID_Product")
                    .HasMaxLength(50);

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.Month)
                    .HasColumnName("month")
                    .HasMaxLength(2);

                entity.Property(e => e.Protype).HasMaxLength(3);

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.TreatmentDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(50);

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<Rptempcoylist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rptempcoylist");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Product)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Rptempprovcap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rptempprovcap");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Product)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Rptempprovlist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rptempprovlist");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Product)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Rptexpiring>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RPTExpiring");

                entity.Property(e => e.AddedBill).HasColumnType("money");

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.CompanyCode).HasMaxLength(15);

                entity.Property(e => e.CompanyName).HasMaxLength(60);

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.MrecId).HasColumnName("MRec_id");

                entity.Property(e => e.NewBill).HasColumnType("money");

                entity.Property(e => e.Payment).HasColumnType("money");

                entity.Property(e => e.PaymentAnalysis).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(1);
            });

            modelBuilder.Entity<Rptinvoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rptinvoice");

                entity.Property(e => e.AmtExpected).HasColumnType("money");

                entity.Property(e => e.BillId).HasColumnName("Bill_id");

                entity.Property(e => e.BillType).HasMaxLength(1);

                entity.Property(e => e.Cancel)
                    .HasColumnName("cancel")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CompanyCode).HasMaxLength(10);

                entity.Property(e => e.CompanyName).HasMaxLength(150);

                entity.Property(e => e.Confirmed)
                    .HasColumnName("confirmed")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmployeeNo).HasMaxLength(50);

                entity.Property(e => e.InvoiceNo).HasMaxLength(15);

                entity.Property(e => e.Paid)
                    .HasColumnName("paid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Part).HasDefaultValueSql("((0))");

                entity.Property(e => e.PeriodFrom).HasColumnType("date");

                entity.Property(e => e.PeriodTo).HasColumnType("date");

                entity.Property(e => e.Remainbal)
                    .HasColumnName("remainbal")
                    .HasColumnType("money");

                entity.Property(e => e.Remark).HasColumnType("ntext");

                entity.Property(e => e.TransDate).HasColumnType("date");
            });

            modelBuilder.Entity<Rptnhisclient>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rptnhisclient");

                entity.Property(e => e.Clientcode)
                    .HasColumnName("clientcode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Clientname)
                    .HasColumnName("clientname")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Hcpadd)
                    .HasColumnName("hcpadd")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Hcpcode)
                    .HasColumnName("hcpcode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Indcode).HasColumnName("indcode");

                entity.Property(e => e.Nhisnumber)
                    .HasColumnName("nhisnumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Othernames)
                    .HasColumnName("othernames")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasColumnName("surname")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SbuTb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sbu_tb");

                entity.Property(e => e.Datemove).HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("ID_company");

                entity.Property(e => e.Sbu)
                    .HasColumnName("SBU")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UserMove)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("schedule");

                entity.Property(e => e.BeginDate)
                    .HasColumnName("Begin_date")
                    .HasColumnType("date");

                entity.Property(e => e.Discount)
                    .HasColumnName("discount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EndDate)
                    .HasColumnName("End_date")
                    .HasColumnType("date");

                entity.Property(e => e.IdCompany).HasColumnName("ID_company");

                entity.Property(e => e.Payable)
                    .HasColumnName("payable")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PolNo)
                    .HasColumnName("pol_no")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TotalPremium).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Transdate)
                    .HasColumnName("transdate")
                    .HasColumnType("date");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Scphist>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("scphist");

                entity.Property(e => e.Classification).HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Diagnosis).HasMaxLength(200);

                entity.Property(e => e.EmployeeName).HasMaxLength(150);

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TreatmentDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Setss>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("setss");

                entity.Property(e => e.Billmth).HasColumnName("billmth");

                entity.Property(e => e.Capcond).HasColumnName("capcond");

                entity.Property(e => e.Capdays).HasColumnName("capdays");

                entity.Property(e => e.ChgprovSms)
                    .HasColumnName("chgprov_sms")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ClientPath)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.DeactivateSms)
                    .HasColumnName("deactivate_sms")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Deprejectsms)
                    .HasColumnName("deprejectsms")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DomainName)
                    .HasColumnName("Domain_Name")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnrolleePath)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.Enrolleenocode)
                    .HasColumnName("enrolleenocode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Groupage).HasColumnName("groupage");

                entity.Property(e => e.Groupdepage).HasColumnName("groupdepage");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Maxdepage).HasColumnName("maxdepage");

                entity.Property(e => e.Maxempage).HasColumnName("maxempage");

                entity.Property(e => e.NewRegSms)
                    .HasColumnName("new_reg_sms")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PicsPath)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.Portalpath)
                    .HasColumnName("portalpath")
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.Prefix)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderPath)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.Pwd)
                    .HasColumnName("pwd")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rejectsms)
                    .HasColumnName("rejectsms")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Retaildepage).HasColumnName("retaildepage");

                entity.Property(e => e.Sender)
                    .HasColumnName("sender")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SenderName)
                    .HasColumnName("Sender_Name")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SenderPassword)
                    .HasColumnName("Sender_Password")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Smsname)
                    .HasColumnName("smsname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Smspwd)
                    .HasColumnName("smspwd")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Smsusr)
                    .HasColumnName("smsusr")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SmtpClientHost)
                    .HasColumnName("Smtp_Client_Host")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Setupimg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("setupimg");

                entity.Property(e => e.Claimshead)
                    .HasColumnName("claimshead")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Header)
                    .HasColumnName("header")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SexTb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SexTB");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(1);

                entity.Property(e => e.SexCode)
                    .IsRequired()
                    .HasColumnName("SEX_CODE")
                    .HasMaxLength(15);

                entity.Property(e => e.SexDescription)
                    .HasColumnName("SEX_DESCRIPTION")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<Sickness>(entity =>
            {
                entity.HasKey(e => e.IdSickness);

                entity.HasIndex(e => e.SicknessName)
                    .HasName("Key_SicknessName")
                    .IsUnique();

                entity.Property(e => e.IdSickness)
                    .HasColumnName("ID_Sickness")
                    .ValueGeneratedNever();

                entity.Property(e => e.SicknessName)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Smsconfig>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("smsconfig");

                entity.Property(e => e.Api)
                    .HasColumnName("api")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sender)
                    .HasColumnName("sender")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Specialty>(entity =>
            {
                entity.HasKey(e => e.IdSpecialty);

                entity.HasIndex(e => e.SpecialtyName)
                    .HasName("Key_Specialty_Name")
                    .IsUnique();

                entity.Property(e => e.IdSpecialty).HasColumnName("ID_Specialty");

                entity.Property(e => e.Narration)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialtyName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StaffLevelTb>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("StaffLevelTB");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(15);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<States>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.HasIndex(e => e.Description)
                    .HasName("Key_States_StateName")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.HasIndex(e => e.Description)
                    .HasName("FK_Status")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAccounthead>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblAccounthead");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.HeadName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAccounthead2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblAccounthead2");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.HeadName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCompanyHead>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblCompanyHead");

                entity.Property(e => e.DOBacc)
                    .HasColumnName("D_O_BAcc")
                    .HasColumnType("datetime");

                entity.Property(e => e.DOBhmoc)
                    .HasColumnName("D_O_BHMOC")
                    .HasColumnType("datetime");

                entity.Property(e => e.DOBmd)
                    .HasColumnName("D_O_BMD")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmailAcc).HasMaxLength(60);

                entity.Property(e => e.EmailHmoc)
                    .HasColumnName("EmailHMOC")
                    .HasMaxLength(60);

                entity.Property(e => e.EmailMd)
                    .HasColumnName("EmailMD")
                    .HasMaxLength(60);

                entity.Property(e => e.GsmNoAcc)
                    .HasColumnName("GSM_NoAcc")
                    .HasMaxLength(50);

                entity.Property(e => e.GsmNoHmoc)
                    .HasColumnName("GSM_NoHMOC")
                    .HasMaxLength(50);

                entity.Property(e => e.GsmNoMd)
                    .HasColumnName("GSM_NoMD")
                    .HasMaxLength(50);

                entity.Property(e => e.HeadId)
                    .HasColumnName("Head_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.HeadNameAcc)
                    .HasColumnName("Head_NameAcc")
                    .HasMaxLength(60);

                entity.Property(e => e.HeadNameHmoc)
                    .HasColumnName("Head_NameHMOC")
                    .HasMaxLength(60);

                entity.Property(e => e.HeadNameMd)
                    .HasColumnName("Head_NameMD")
                    .HasMaxLength(60);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");
            });

            modelBuilder.Entity<TblCompanyHead2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblCompanyHead2");

                entity.Property(e => e.DOB)
                    .HasColumnName("D_O_B")
                    .HasColumnType("datetime");

                entity.Property(e => e.Designation).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.GsmNo)
                    .HasColumnName("GSM_No")
                    .HasMaxLength(50);

                entity.Property(e => e.HeadId)
                    .HasColumnName("Head_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.HeadName)
                    .HasColumnName("Head_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.PhoneNo1).HasMaxLength(50);

                entity.Property(e => e.PhoneNo2).HasMaxLength(50);
            });

            modelBuilder.Entity<TblHrhead>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblHRhead");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.HeadName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblHrhead2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblHRhead2");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.HeadName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblProviderHead>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblProviderHead");

                entity.Property(e => e.DOBacc)
                    .HasColumnName("D_O_BAcc")
                    .HasColumnType("datetime");

                entity.Property(e => e.DOBhmoc)
                    .HasColumnName("D_O_BHMOC")
                    .HasColumnType("datetime");

                entity.Property(e => e.DOBmd)
                    .HasColumnName("D_O_BMD")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmailAcc).HasMaxLength(60);

                entity.Property(e => e.EmailHmoc)
                    .HasColumnName("EmailHMOC")
                    .HasMaxLength(60);

                entity.Property(e => e.EmailMd)
                    .HasColumnName("EmailMD")
                    .HasMaxLength(60);

                entity.Property(e => e.GsmNoAcc)
                    .HasColumnName("GSM_NoAcc")
                    .HasMaxLength(50);

                entity.Property(e => e.GsmNoHmoc)
                    .HasColumnName("GSM_NoHMOC")
                    .HasMaxLength(50);

                entity.Property(e => e.GsmNoMd)
                    .HasColumnName("GSM_NoMD")
                    .HasMaxLength(50);

                entity.Property(e => e.HeadId)
                    .HasColumnName("Head_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.HeadNameAcc)
                    .HasColumnName("Head_NameAcc")
                    .HasMaxLength(60);

                entity.Property(e => e.HeadNameHmoc)
                    .HasColumnName("Head_NameHMOC")
                    .HasMaxLength(60);

                entity.Property(e => e.HeadNameMd)
                    .HasColumnName("Head_NameMD")
                    .HasMaxLength(60);

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");
            });

            modelBuilder.Entity<TerminatedCases>(entity =>
            {
                entity.HasKey(e => e.IdEndCases);

                entity.Property(e => e.IdEndCases).HasColumnName("ID_EndCases");

                entity.Property(e => e.CaseType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdReason).HasColumnName("ID_Reason");

                entity.Property(e => e.PolicyNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TreatmentClass>(entity =>
            {
                entity.HasKey(e => e.IdTreatmentClass);

                entity.Property(e => e.IdTreatmentClass)
                    .HasColumnName("ID_TreatmentClass")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.TreatmentClass1)
                    .HasColumnName("TreatmentClass")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TreatmentList>(entity =>
            {
                entity.HasKey(e => e.IdTreatmentList);

                entity.HasIndex(e => e.Narration)
                    .HasName("Key_TreatmentList_Narration")
                    .IsUnique();

                entity.Property(e => e.IdTreatmentList)
                    .HasColumnName("ID_TreatmentList")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CostA)
                    .HasColumnName("Cost_A")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CostB)
                    .HasColumnName("Cost_B")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CostC)
                    .HasColumnName("Cost_C")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdTreatmentClass)
                    .HasColumnName("ID_TreatmentClass")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Narration)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Specification)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Strenght)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TreatmentResult>(entity =>
            {
                entity.HasKey(e => e.IdTreatmentResult);

                entity.HasIndex(e => e.TreatmentResult1)
                    .HasName("Key_TreatmentResult_TreatmentResult")
                    .IsUnique();

                entity.Property(e => e.IdTreatmentResult)
                    .HasColumnName("ID_TreatmentResult")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TreatmentResult1)
                    .IsRequired()
                    .HasColumnName("TreatmentResult")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewDepSbu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Dep_sbu");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.Sbu)
                    .HasColumnName("SBU")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewEnrDepSbu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_EnrDep_Sbu");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.Sbu)
                    .HasColumnName("SBU")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewEnrSbu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Enr_sbu");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdBranch).HasColumnName("ID_Branch");

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.Sbu)
                    .HasColumnName("SBU")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewSbuDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_SBU_DETAILS");

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Category).HasMaxLength(1);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactOfficer)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Datemove).HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasColumnName("email2")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.IdState)
                    .HasColumnName("ID_State")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumbers)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sbu)
                    .HasColumnName("SBU")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.SbuStatus)
                    .HasColumnName("SBU_STATUS")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Sn).HasColumnName("sn");

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UserMove)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VoucherNo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdVoucher)
                    .HasColumnName("ID_Voucher")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PostPeriod)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.Property(e => e.VoucherNo1)
                    .HasColumnName("VoucherNo")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WardTbl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WARD_TBL");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Xxx>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("xxx");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.JobLevel)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Xyz>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("XYZ");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNo)
                    .HasColumnName("empNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
