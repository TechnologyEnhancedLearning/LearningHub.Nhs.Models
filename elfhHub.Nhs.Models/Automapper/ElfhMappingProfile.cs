// <copyright file="ElfhMappingProfile.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Automapper
{
    using AutoMapper;
    using elfhHub.Nhs.Models.Common;
    using elfhHub.Nhs.Models.Entities;

    /// <summary>
    /// The elfh mapping profile.
    /// </summary>
    public class ElfhMappingProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElfhMappingProfile"/> class.
        /// </summary>
        public ElfhMappingProfile()
        {
            this.CreateMap<JobRole, JobRoleBasicViewModel>()
                .ForMember(d => d.NameWithStaffGroup, x => x.MapFrom(s => s.Name + " (" + s.StaffGroup.Name + ")"))
                .ForMember(d => d.MedicalCouncilName, x => x.MapFrom(s => (s.MedicalCouncil == null) ? string.Empty : s.MedicalCouncil.Name))
                .ForMember(d => d.MedicalCouncilCode, x => x.MapFrom(s => (s.MedicalCouncil == null) ? string.Empty : s.MedicalCouncil.Code))
                ;

            this.CreateMap<Region, GenericListViewModel>();
            this.CreateMap<Country, GenericListViewModel>();

            this.CreateMap<Location, LocationBasicViewModel>()
                .ForMember(d => d.Name, x => x.MapFrom(l => l.Name + HelperMethods.AddPrefix(l.SubName) + " (" + l.Type.Name + ")"))
                .ForMember(d => d.Address, x => x.MapFrom(l => l.Address1 + HelperMethods.AddPrefix(l.Address2) + HelperMethods.AddPrefix(l.Address3) + HelperMethods.AddPrefix(l.Address3) + HelperMethods.AddPrefix(l.County) + HelperMethods.AddPrefix(l.PostCode)))
                ;

            this.CreateMap<UserSecurityQuestion, UserSecurityQuestionViewModel>()
                .ForMember(d => d.QuestionText, x => x.MapFrom(l => l.SecurityQuestion.Text))
                ;
            this.CreateMap<UserSecurityQuestionViewModel, UserSecurityQuestion>();

            this.CreateMap<UserEmployment, UserEmploymentViewModel>();
            this.CreateMap<UserEmploymentViewModel, UserEmployment>();

            this.CreateMap<User, UserAdminBasicViewModel>();
            this.CreateMap<User, UserAdminDetailViewModel>()
                .ForMember(d => d.OriginalFirstName, x => x.MapFrom(l => l.FirstName))
                .ForMember(d => d.OriginalLastName, x => x.MapFrom(l => l.LastName))
                .ForMember(d => d.OriginalEmailAddress, x => x.MapFrom(l => l.EmailAddress))
                .ForMember(d => d.FailedLoginCount, x => x.MapFrom(l => l.PasswordLifeCounter));

            this.CreateMap<UserHistoryStoredProcResult, UserHistoryViewModel>()
                .ForMember(d => d.Detail, x => x.MapFrom(l => l.DetailedInfo))
                .ForMember(d => d.UserHistoryType, x => x.MapFrom(l => l.Description))
                .ForMember(d => d.CreatedDate, x => x.MapFrom(l => l.CreatedDate.DateTime));

            this.CreateMap<UserRoleUpgrade, UserRoleUpgradeViewModel>();
        }
    }
}
