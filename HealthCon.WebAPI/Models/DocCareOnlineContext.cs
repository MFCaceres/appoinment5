using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HealthCon.WebAPI.Models
{
    public partial class DocCareOnlineContext : DbContext
    {
        public DocCareOnlineContext()
        {
        }

        public DocCareOnlineContext(DbContextOptions<DocCareOnlineContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Addresses { get; set; } = null!;
        public virtual DbSet<Allergy> Allergies { get; set; } = null!;
        public virtual DbSet<Appointment> Appointments { get; set; } = null!;
        public virtual DbSet<AppointmentChat> AppointmentChats { get; set; } = null!;
        public virtual DbSet<AppointmentNote> AppointmentNotes { get; set; } = null!;
        public virtual DbSet<AppointmentReview> AppointmentReviews { get; set; } = null!;
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; } = null!;
        public virtual DbSet<BoardCertification> BoardCertifications { get; set; } = null!;
        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<ClinicAdminMap> ClinicAdminMaps { get; set; } = null!;
        public virtual DbSet<ClinicHcp> ClinicHcps { get; set; } = null!;
        public virtual DbSet<ClinicOfficeHour> ClinicOfficeHours { get; set; } = null!;
        public virtual DbSet<ClinicProfile> ClinicProfiles { get; set; } = null!;
        public virtual DbSet<ClinicProfileImageFilePath> ClinicProfileImageFilePaths { get; set; } = null!;
        public virtual DbSet<ClinicSpeciality> ClinicSpecialities { get; set; } = null!;
        public virtual DbSet<ClinicType> ClinicTypes { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<Currency> Currencies { get; set; } = null!;
        public virtual DbSet<Diagnosis> Diagnoses { get; set; } = null!;
        public virtual DbSet<Docsubscription> Docsubscriptions { get; set; } = null!;
        public virtual DbSet<HcpboardCertification> HcpboardCertifications { get; set; } = null!;
        public virtual DbSet<Hcpeducation> Hcpeducations { get; set; } = null!;
        public virtual DbSet<Hcpprofile> Hcpprofiles { get; set; } = null!;
        public virtual DbSet<Hcpslot> Hcpslots { get; set; } = null!;
        public virtual DbSet<Hcpspecialization> Hcpspecializations { get; set; } = null!;
        public virtual DbSet<Hcpsuffix> Hcpsuffixes { get; set; } = null!;
        public virtual DbSet<Language> Languages { get; set; } = null!;
        public virtual DbSet<LoginAudit> LoginAudits { get; set; } = null!;
        public virtual DbSet<Medication> Medications { get; set; } = null!;
        public virtual DbSet<Member> Members { get; set; } = null!;
        public virtual DbSet<MessageCentre> MessageCentres { get; set; } = null!;
        public virtual DbSet<MigrationHistory> MigrationHistories { get; set; } = null!;
        public virtual DbSet<PayRate> PayRates { get; set; } = null!;
        public virtual DbSet<Paypalipn> Paypalipns { get; set; } = null!;
        public virtual DbSet<Report> Reports { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Salutation> Salutations { get; set; } = null!;
        public virtual DbSet<SecurityQuestion> SecurityQuestions { get; set; } = null!;
        public virtual DbSet<Speciality> Specialities { get; set; } = null!;
        public virtual DbSet<State> States { get; set; } = null!;
        public virtual DbSet<SubscribtionPrice> SubscribtionPrices { get; set; } = null!;
        public virtual DbSet<SubscribtionPriceEditAudit> SubscribtionPriceEditAudits { get; set; } = null!;
        public virtual DbSet<Subscriptionpayment> Subscriptionpayments { get; set; } = null!;
        public virtual DbSet<Suffix> Suffixes { get; set; } = null!;
        public virtual DbSet<Tblrefreshtoken> Tblrefreshtokens { get; set; } = null!;
        public virtual DbSet<TimeZone> TimeZones { get; set; } = null!;
        public virtual DbSet<Uom> Uoms { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserClaim> UserClaims { get; set; } = null!;
        public virtual DbSet<UserLanguage> UserLanguages { get; set; } = null!;
        public virtual DbSet<UserLogin> UserLogins { get; set; } = null!;
        public virtual DbSet<UserRole> UserRoles { get; set; } = null!;
        public virtual DbSet<UserSocialLogin> UserSocialLogins { get; set; } = null!;
        public virtual DbSet<UserType> UserTypes { get; set; } = null!;
        public virtual DbSet<Users1> Users1s { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=IN3220095W1; Database=DocCareOnline;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("Address");

                entity.Property(e => e.Address1).HasMaxLength(150);

                entity.Property(e => e.Address2).HasMaxLength(150);

                entity.Property(e => e.BuisnessContactNo).HasColumnName("BuisnessContactNO");

                entity.Property(e => e.ContactPersonName).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FaxNo).HasColumnName("FaxNO");

                entity.Property(e => e.PersonalContactNo).HasColumnName("PersonalContactNO");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_dbo.Address_dbo.City_CityId");

                entity.HasOne(d => d.ClinicProfile)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.ClinicProfileId)
                    .HasConstraintName("FK_dbo.Address_dbo.ClinicProfile_ClinicProfileId");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_dbo.Address_dbo.Country_CountryId");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_dbo.Address_dbo.State_StateId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.Address_dbo.User_UserId");
            });

            modelBuilder.Entity<Allergy>(entity =>
            {
                entity.ToTable("Allergy");

                entity.Property(e => e.AllergyDescription).HasMaxLength(200);

                entity.Property(e => e.AllergyName).HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Allergies)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.Allergy_dbo.User_UserId");
            });

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.ToTable("Appointment");

                entity.Property(e => e.AmountPaid).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppointmentBookedOn).HasColumnType("datetime");

                entity.Property(e => e.AppointmentDuration).HasColumnType("datetime");

                entity.Property(e => e.AppointmentEndTime).HasColumnType("datetime");

                entity.Property(e => e.AppointmentReason).HasMaxLength(200);

                entity.Property(e => e.AppointmentStartTime).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.HcpnoteStatus).HasColumnName("HCPNoteStatus");

                entity.Property(e => e.HcpslotId).HasColumnName("HCPSlotId");

                entity.Property(e => e.IsAcknowledgeHcp).HasColumnName("IsAcknowledgeHCP");

                entity.Property(e => e.IsHcpattained).HasColumnName("IsHCPAttained");

                entity.Property(e => e.IsTermsConditionHcp).HasColumnName("IsTermsConditionHCP");

                entity.Property(e => e.Status).HasMaxLength(20);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.AppointmentTakenByNavigation)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.AppointmentTakenBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Appointment_dbo.User_AppointmentTakenBy");

                entity.HasOne(d => d.Hcpslot)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.HcpslotId)
                    .HasConstraintName("FK_dbo.Appointment_dbo.HCPSlot_HCPSlotId");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_dbo.Appointment_dbo.Member_MemberId");
            });

            modelBuilder.Entity<AppointmentChat>(entity =>
            {
                entity.ToTable("AppointmentChat");

                entity.Property(e => e.ChatText).HasMaxLength(2000);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Appointment)
                    .WithMany(p => p.AppointmentChats)
                    .HasForeignKey(d => d.AppointmentId)
                    .HasConstraintName("FK_dbo.AppointmentChat_dbo.Appointment_AppointmentId");
            });

            modelBuilder.Entity<AppointmentNote>(entity =>
            {
                entity.ToTable("AppointmentNote");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(1000);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Appointment)
                    .WithMany(p => p.AppointmentNotes)
                    .HasForeignKey(d => d.AppointmentId)
                    .HasConstraintName("FK_dbo.AppointmentNote_dbo.Appointment_AppointmentId");
            });

            modelBuilder.Entity<AppointmentReview>(entity =>
            {
                entity.ToTable("AppointmentReview");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Hcpcomment)
                    .HasMaxLength(200)
                    .HasColumnName("HCPComment");

                entity.Property(e => e.HcpdocCareExperience)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("HCPDocCareExperience");

                entity.Property(e => e.Hcpid).HasColumnName("HCPId");

                entity.Property(e => e.Hcpname).HasColumnName("HCPName");

                entity.Property(e => e.Hcprating).HasColumnName("HCPRating");

                entity.Property(e => e.HcpsoundVideoQuality)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("HCPSoundVideoQuality");

                entity.Property(e => e.PatientComment).HasMaxLength(200);

                entity.Property(e => e.PatientSoundVideoQuality).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Appointment)
                    .WithMany(p => p.AppointmentReviews)
                    .HasForeignKey(d => d.AppointmentId)
                    .HasConstraintName("FK_dbo.AppointmentReview_dbo.Appointment_AppointmentId");
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(128);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.AspNetUser)
                    .HasForeignKey<AspNetUser>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.AspNetUsers_dbo.UserLogin_Id");
            });

            modelBuilder.Entity<BoardCertification>(entity =>
            {
                entity.ToTable("BoardCertification");

                entity.Property(e => e.CertificationDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CertificationTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("City");

                entity.Property(e => e.CityCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CityName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.City_dbo.State_StateId");
            });

            modelBuilder.Entity<ClinicAdminMap>(entity =>
            {
                entity.ToTable("ClinicAdminMap");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Admin)
                    .WithMany(p => p.ClinicAdminMaps)
                    .HasForeignKey(d => d.AdminId)
                    .HasConstraintName("FK_dbo.ClinicAdminMap_dbo.User_AdminId");

                entity.HasOne(d => d.Clinic)
                    .WithMany(p => p.ClinicAdminMaps)
                    .HasForeignKey(d => d.ClinicId)
                    .HasConstraintName("FK_dbo.ClinicAdminMap_dbo.ClinicProfile_ClinicId");
            });

            modelBuilder.Entity<ClinicHcp>(entity =>
            {
                entity.HasKey(e => e.ClinicDoctorId)
                    .HasName("PK_dbo.ClinicHCP");

                entity.ToTable("ClinicHCP");

                entity.Property(e => e.ClinicPayRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Hcpid).HasColumnName("HCPId");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.VideoPayRate).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.ClinicProfile)
                    .WithMany(p => p.ClinicHcps)
                    .HasForeignKey(d => d.ClinicProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ClinicHCP_dbo.ClinicProfile_ClinicProfileId");

                entity.HasOne(d => d.Hcp)
                    .WithMany(p => p.ClinicHcps)
                    .HasForeignKey(d => d.Hcpid)
                    .HasConstraintName("FK_dbo.ClinicHCP_dbo.User_HCPId");
            });

            modelBuilder.Entity<ClinicOfficeHour>(entity =>
            {
                entity.ToTable("ClinicOfficeHour");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Day).HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.ClinicProfile)
                    .WithMany(p => p.ClinicOfficeHours)
                    .HasForeignKey(d => d.ClinicProfileId)
                    .HasConstraintName("FK_dbo.ClinicOfficeHour_dbo.ClinicProfile_ClinicProfileId");
            });

            modelBuilder.Entity<ClinicProfile>(entity =>
            {
                entity.ToTable("ClinicProfile");

                entity.Property(e => e.AboutUs).HasMaxLength(250);

                entity.Property(e => e.BuisnessLicenseNo).HasMaxLength(100);

                entity.Property(e => e.ClinicName).HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.InsuranceAccepted).HasMaxLength(100);

                entity.Property(e => e.LicenseExpiration).HasColumnType("datetime");

                entity.Property(e => e.MedicalAffiliation).HasMaxLength(100);

                entity.Property(e => e.TrialEndDate).HasColumnType("datetime");

                entity.Property(e => e.TrialStartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.ClinicType)
                    .WithMany(p => p.ClinicProfiles)
                    .HasForeignKey(d => d.ClinicTypeId)
                    .HasConstraintName("FK_dbo.ClinicProfile_dbo.ClinicType_ClinicTypeId");

                entity.HasOne(d => d.LicenseState)
                    .WithMany(p => p.ClinicProfiles)
                    .HasForeignKey(d => d.LicenseStateId)
                    .HasConstraintName("FK_ClinicProfile_State");

                entity.HasOne(d => d.Timezone)
                    .WithMany(p => p.ClinicProfiles)
                    .HasForeignKey(d => d.TimezoneId)
                    .HasConstraintName("FK_dbo.ClinicProfile_dbo.TimeZone_TimezoneId");
            });

            modelBuilder.Entity<ClinicProfileImageFilePath>(entity =>
            {
                entity.HasKey(e => e.ClinicProfileImgFilePathId)
                    .HasName("PK_dbo.ClinicProfileImageFilePath");

                entity.ToTable("ClinicProfileImageFilePath");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.ClinicProfile)
                    .WithMany(p => p.ClinicProfileImageFilePaths)
                    .HasForeignKey(d => d.ClinicProfileId)
                    .HasConstraintName("FK_dbo.ClinicProfileImageFilePath_dbo.ClinicProfile_ClinicProfileId");
            });

            modelBuilder.Entity<ClinicSpeciality>(entity =>
            {
                entity.ToTable("ClinicSpeciality");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.ClinicProfile)
                    .WithMany(p => p.ClinicSpecialities)
                    .HasForeignKey(d => d.ClinicProfileId)
                    .HasConstraintName("FK_dbo.ClinicSpeciality_dbo.ClinicProfile_ClinicProfileId");

                entity.HasOne(d => d.Speciality)
                    .WithMany(p => p.ClinicSpecialities)
                    .HasForeignKey(d => d.SpecialityId)
                    .HasConstraintName("FK_dbo.ClinicSpeciality_dbo.Speciality_SpecialityId");
            });

            modelBuilder.Entity<ClinicType>(entity =>
            {
                entity.ToTable("ClinicType");

                entity.Property(e => e.ClinicTypeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClinicTypeDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.ToTable("Currency");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Diagnosis>(entity =>
            {
                entity.HasKey(e => e.DiagnosisName)
                    .HasName("PK_dbo.Diagnosis");

                entity.ToTable("Diagnosis");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DiagnosisDescription).HasMaxLength(200);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Diagnoses)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.Diagnosis_dbo.User_UserId");
            });

            modelBuilder.Entity<Docsubscription>(entity =>
            {
                entity.ToTable("DOCSUBSCRIPTIONS");

                entity.Property(e => e.Docsubscriptionid).HasColumnName("DOCSUBSCRIPTIONID");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(100)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATE");

                entity.Property(e => e.CurrentTotalAmountOfAllPayments).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EndingDate).HasColumnType("datetime");

                entity.Property(e => e.Errordetails).HasColumnName("ERRORDETAILS");

                entity.Property(e => e.Isdeleted)
                    .HasColumnName("ISDELETED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxAmountPerPayment).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MaxTotalAmountOfAllPayments).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(100)
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIEDDATE");

                entity.Property(e => e.StartingDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<HcpboardCertification>(entity =>
            {
                entity.ToTable("HCPBoardCertification");

                entity.Property(e => e.HcpboardCertificationId).HasColumnName("HCPBoardCertificationId");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Hcpid).HasColumnName("HCPId");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.BoardCertification)
                    .WithMany(p => p.HcpboardCertifications)
                    .HasForeignKey(d => d.BoardCertificationId)
                    .HasConstraintName("FK_dbo.HCPBoardCertification_dbo.BoardCertification_BoardCertificationId");

                entity.HasOne(d => d.Hcp)
                    .WithMany(p => p.HcpboardCertifications)
                    .HasForeignKey(d => d.Hcpid)
                    .HasConstraintName("FK_dbo.HCPBoardCertification_dbo.User_HCPId");
            });

            modelBuilder.Entity<Hcpeducation>(entity =>
            {
                entity.ToTable("HCPEducation");

                entity.Property(e => e.HcpeducationId).HasColumnName("HCPEducationId");

                entity.Property(e => e.AwardCertification).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.GraduationYear).HasColumnType("datetime");

                entity.Property(e => e.Hcpid).HasColumnName("HCPId");

                entity.Property(e => e.HospitalAffiliation).HasMaxLength(500);

                entity.Property(e => e.MedicalAttendedSchoolName).HasMaxLength(150);

                entity.Property(e => e.ProfessionalMembership).HasMaxLength(250);

                entity.Property(e => e.ResidencyFocus).HasMaxLength(250);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.GraduatedCountry)
                    .WithMany(p => p.Hcpeducations)
                    .HasForeignKey(d => d.GraduatedCountryId)
                    .HasConstraintName("FK_dbo.HCPEducation_dbo.Country_GraduatedCountryId");

                entity.HasOne(d => d.Hcp)
                    .WithMany(p => p.Hcpeducations)
                    .HasForeignKey(d => d.Hcpid)
                    .HasConstraintName("FK_dbo.HCPEducation_dbo.User_HCPId");
            });

            modelBuilder.Entity<Hcpprofile>(entity =>
            {
                entity.ToTable("HCPProfile");

                entity.Property(e => e.HcpprofileId).HasColumnName("HCPProfileId");

                entity.Property(e => e.AboutUs).HasMaxLength(250);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Hcpid).HasColumnName("HCPId");

                entity.Property(e => e.HcpprofileImageUrl).HasColumnName("HCPProfileImageURL");

                entity.Property(e => e.InsuranceName).HasMaxLength(1000);

                entity.Property(e => e.IsNpiapproved).HasColumnName("IsNPIApproved");

                entity.Property(e => e.LicenseExpireDate).HasColumnType("datetime");

                entity.Property(e => e.Npi).HasColumnName("NPI");

                entity.Property(e => e.PracticeName).HasMaxLength(100);

                entity.Property(e => e.PractisingSince).HasColumnType("datetime");

                entity.Property(e => e.TrialEndDate).HasColumnType("datetime");

                entity.Property(e => e.TrialStartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Hcp)
                    .WithMany(p => p.Hcpprofiles)
                    .HasForeignKey(d => d.Hcpid)
                    .HasConstraintName("FK_dbo.HCPProfile_dbo.User_HCPId");

                entity.HasOne(d => d.LicenseState)
                    .WithMany(p => p.Hcpprofiles)
                    .HasForeignKey(d => d.LicenseStateId)
                    .HasConstraintName("FK_dbo.HCPProfile_dbo.State_LicenseStateId");

                entity.HasOne(d => d.TimeZone)
                    .WithMany(p => p.Hcpprofiles)
                    .HasForeignKey(d => d.TimeZoneId)
                    .HasConstraintName("FK_dbo.HCPProfile_dbo.TimeZone_TimeZoneId");
            });

            modelBuilder.Entity<Hcpslot>(entity =>
            {
                entity.ToTable("HCPSlot");

                entity.Property(e => e.HcpslotId).HasColumnName("HCPSlotId");

                entity.Property(e => e.AvailabiltyMode).HasMaxLength(10);

                entity.Property(e => e.ClinicHcpid).HasColumnName("ClinicHCPId");

                entity.Property(e => e.ClinicName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Hcpid).HasColumnName("HCPId");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.ClinicHcp)
                    .WithMany(p => p.Hcpslots)
                    .HasForeignKey(d => d.ClinicHcpid)
                    .HasConstraintName("FK_dbo.HCPSlot_dbo.ClinicHCP_ClinicHCPId");

                entity.HasOne(d => d.ClinicProfile)
                    .WithMany(p => p.Hcpslots)
                    .HasForeignKey(d => d.ClinicProfileId)
                    .HasConstraintName("FK_dbo.HCPSlot_dbo.ClinicProfile_ClinicProfileId");

                entity.HasOne(d => d.Hcp)
                    .WithMany(p => p.Hcpslots)
                    .HasForeignKey(d => d.Hcpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.HCPSlot_dbo.User_HCPId");

                entity.HasOne(d => d.TimeZone)
                    .WithMany(p => p.Hcpslots)
                    .HasForeignKey(d => d.TimeZoneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.HCPSlot_dbo.TimeZone_TimeZoneId");
            });

            modelBuilder.Entity<Hcpspecialization>(entity =>
            {
                entity.ToTable("HCPSpecialization");

                entity.Property(e => e.HcpspecializationId).HasColumnName("HCPSpecializationId");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Hcpid).HasColumnName("HCPId");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Hcp)
                    .WithMany(p => p.Hcpspecializations)
                    .HasForeignKey(d => d.Hcpid)
                    .HasConstraintName("FK_dbo.HCPSpecialization_dbo.User_HCPId");

                entity.HasOne(d => d.Speciality)
                    .WithMany(p => p.Hcpspecializations)
                    .HasForeignKey(d => d.SpecialityId)
                    .HasConstraintName("FK_dbo.HCPSpecialization_dbo.Speciality_SpecialityId");
            });

            modelBuilder.Entity<Hcpsuffix>(entity =>
            {
                entity.ToTable("HCPSuffix");

                entity.Property(e => e.HcpsuffixId).HasColumnName("HCPSuffixId");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Hcpid).HasColumnName("HCPId");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Hcp)
                    .WithMany(p => p.Hcpsuffixes)
                    .HasForeignKey(d => d.Hcpid)
                    .HasConstraintName("FK_dbo.HCPSuffix_dbo.User_HCPId");

                entity.HasOne(d => d.Suffix)
                    .WithMany(p => p.Hcpsuffixes)
                    .HasForeignKey(d => d.SuffixId)
                    .HasConstraintName("FK_dbo.HCPSuffix_dbo.Suffix_SuffixId");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.ToTable("Language");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LanguageName).HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<LoginAudit>(entity =>
            {
                entity.ToTable("LoginAudit");

                entity.Property(e => e.LogInTime).HasColumnType("datetime");

                entity.Property(e => e.LogOutTime).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LoginAudits)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.LoginAudit_dbo.User_UserId");
            });

            modelBuilder.Entity<Medication>(entity =>
            {
                entity.ToTable("Medication");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.MedicationName).HasMaxLength(100);

                entity.Property(e => e.PescribeDescription).HasMaxLength(200);

                entity.Property(e => e.PrescribeEndDate).HasColumnType("datetime");

                entity.Property(e => e.PrescribeStartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.UnitNavigation)
                    .WithMany(p => p.Medications)
                    .HasForeignKey(d => d.Unit)
                    .HasConstraintName("FK_dbo.Medication_dbo.UOM_Unit");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Medications)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.Medication_dbo.User_UserId");
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.ToTable("Member");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.MiddleName).HasMaxLength(100);

                entity.Property(e => e.Relationship).HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Members)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Member_dbo.User_UserId");
            });

            modelBuilder.Entity<MessageCentre>(entity =>
            {
                entity.ToTable("MessageCentre");

                entity.Property(e => e.AttachmentUrl).HasColumnName("AttachmentURL");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.MessageBody).HasMaxLength(200);

                entity.Property(e => e.MessageDate).HasColumnType("datetime");

                entity.Property(e => e.MessageSubject).HasMaxLength(150);

                entity.Property(e => e.ReceiverMessageStatus).HasMaxLength(50);

                entity.Property(e => e.SenderMessageStatus).HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.ProductVersion).HasMaxLength(32);
            });

            modelBuilder.Entity<PayRate>(entity =>
            {
                entity.ToTable("PayRate");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.ClinicProfile)
                    .WithMany(p => p.PayRates)
                    .HasForeignKey(d => d.ClinicProfileId)
                    .HasConstraintName("FK_dbo.PayRate_dbo.ClinicProfile_ClinicProfileId");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.PayRates)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_dbo.PayRate_dbo.Currency_CurrencyId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PayRates)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.PayRate_dbo.User_UserId");
            });

            modelBuilder.Entity<Paypalipn>(entity =>
            {
                entity.ToTable("PAYPALIPNS");

                entity.Property(e => e.Paypalipnid).HasColumnName("PAYPALIPNID");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(100)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATE");

                entity.Property(e => e.Guid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GUID");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(100)
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIEDDATE");

                entity.Property(e => e.Paypalresponse).HasColumnName("PAYPALRESPONSE");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.ToTable("Report");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ReportDate).HasColumnType("datetime");

                entity.Property(e => e.ReportName).HasMaxLength(50);

                entity.Property(e => e.ReportUrl).HasColumnName("ReportURL");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.Report_dbo.User_UserId");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.RoleId)
                    .HasMaxLength(128)
                    .HasColumnName("RoleID");

                entity.Property(e => e.Name).HasMaxLength(256);
            });

            modelBuilder.Entity<Salutation>(entity =>
            {
                entity.ToTable("Salutation");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.SalutationName)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<SecurityQuestion>(entity =>
            {
                entity.ToTable("SecurityQuestion");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.SecurityQusetion)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Speciality>(entity =>
            {
                entity.ToTable("Speciality");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.SpecialityName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.ToTable("State");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.StateCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.StateName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.States)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.State_dbo.Country_CountryId");
            });

            modelBuilder.Entity<SubscribtionPrice>(entity =>
            {
                entity.ToTable("SubscribtionPrice");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PricingName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<SubscribtionPriceEditAudit>(entity =>
            {
                entity.ToTable("SubscribtionPriceEditAudit");

                entity.Property(e => e.SubscribtionPriceEditAuditId).HasMaxLength(128);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Subscriptionpayment>(entity =>
            {
                entity.ToTable("SUBSCRIPTIONPAYMENTS");

                entity.Property(e => e.Subscriptionpaymentid).HasColumnName("SUBSCRIPTIONPAYMENTID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Errordetails).HasColumnName("ERRORDETAILS");

                entity.Property(e => e.McFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.McGross).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentDate).HasMaxLength(50);

                entity.Property(e => e.PaymentFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentGross).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PreapprovalKey).HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Suffix>(entity =>
            {
                entity.ToTable("Suffix");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.SuffixName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Tblrefreshtoken>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__tblrefre__1788CC4C9F5941E6");

                entity.ToTable("tblrefreshtoken");

                entity.Property(e => e.UserId).HasMaxLength(20);

                entity.Property(e => e.Refreshtoken)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.TokenId)
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TimeZone>(entity =>
            {
                entity.ToTable("TimeZone");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.TimeZoneName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Uom>(entity =>
            {
                entity.ToTable("UOM");

                entity.Property(e => e.Uomid).HasColumnName("UOMId");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Uomname)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("UOMName");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastActivity).HasColumnType("datetime");

                entity.Property(e => e.LastLockout).HasColumnType("datetime");

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.LastPasswordChange).HasColumnType("datetime");

                entity.Property(e => e.PayPalEmail).HasMaxLength(50);

                entity.Property(e => e.RegisteredDate).HasColumnType("datetime");

                entity.Property(e => e.Salutation).HasMaxLength(50);

                entity.Property(e => e.TimeZoneId).HasColumnName("TimeZoneID");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");

                entity.Property(e => e.VerifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.SecurityQuestion)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.SecurityQuestionId)
                    .HasConstraintName("FK_dbo.User_dbo.SecurityQuestion_SecurityQuestionId");

                entity.HasOne(d => d.TimeZone)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.TimeZoneId)
                    .HasConstraintName("FK_dbo.User_dbo.TimeZone_TimeZoneID");

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserTypeId)
                    .HasConstraintName("FK_dbo.User_dbo.UserType_UserTypeID");
            });

            modelBuilder.Entity<UserClaim>(entity =>
            {
                entity.ToTable("UserClaim");

                entity.Property(e => e.IdentityUserId)
                    .HasMaxLength(128)
                    .HasColumnName("IdentityUser_Id");

                entity.HasOne(d => d.IdentityUser)
                    .WithMany(p => p.UserClaims)
                    .HasForeignKey(d => d.IdentityUserId)
                    .HasConstraintName("FK_dbo.UserClaim_dbo.UserLogin_IdentityUser_Id");
            });

            modelBuilder.Entity<UserLanguage>(entity =>
            {
                entity.ToTable("UserLanguage");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.UserLanguages)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_dbo.UserLanguage_dbo.Language_LanguageId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserLanguages)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.UserLanguage_dbo.User_UserId");
            });

            modelBuilder.Entity<UserLogin>(entity =>
            {
                entity.ToTable("UserLogin");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserRoleId, e.RoleId })
                    .HasName("PK_dbo.UserRole");

                entity.ToTable("UserRole");

                entity.Property(e => e.UserRoleId).HasMaxLength(128);

                entity.Property(e => e.RoleId).HasMaxLength(128);

                entity.Property(e => e.IdentityUserId)
                    .HasMaxLength(128)
                    .HasColumnName("IdentityUser_Id");

                entity.HasOne(d => d.IdentityUser)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.IdentityUserId)
                    .HasConstraintName("FK_dbo.UserRole_dbo.UserLogin_IdentityUser_Id");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.UserRole_dbo.Role_RoleId");
            });

            modelBuilder.Entity<UserSocialLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_dbo.UserSocialLogin");

                entity.ToTable("UserSocialLogin");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.IdentityUserId)
                    .HasMaxLength(128)
                    .HasColumnName("IdentityUser_Id");

                entity.HasOne(d => d.IdentityUser)
                    .WithMany(p => p.UserSocialLogins)
                    .HasForeignKey(d => d.IdentityUserId)
                    .HasConstraintName("FK_dbo.UserSocialLogin_dbo.UserLogin_IdentityUser_Id");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.ToTable("UserType");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.UserCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Users1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Users1");

                entity.Property(e => e.Password)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Userid)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
