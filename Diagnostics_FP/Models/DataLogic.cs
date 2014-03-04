using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity.Infrastructure;

namespace Diagnostics_FP.Models
{

    [MetadataType(typeof(MBAnalysisBacterioscopyMetadata))]
    public partial class MBAnalysisBacterioscopy
    {
        public class MBAnalysisBacterioscopyMetadata
        {
            [Required]
            public int MBAnalysisID { get; set; }

            [Required]
            public int MBBacterioscopyOrganismID { get; set; }

            [Required]
            public string ViewField { get; set; }

            [Required]
            public string Value { get; set; }
        }

    }

    [MetadataType(typeof(ContractsAndMBAnalysisTypeMetadata))]
    public partial class ContractsAndMBAnalysisType
    {
        public class ContractsAndMBAnalysisTypeMetadata
        {

            [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:C}")]

            [Required(ErrorMessage = "Обязательное поле")]
            public decimal Price { get; set; }
        }
    }

    [MetadataType(typeof(SampleMetadata))]
    public partial class Sample
    {
        public class SampleMetadata
        {
            public int SampleID { get; set; }
            public int PatientID { get; set; }

            [Required(ErrorMessage = "Обязательное поле")]
            [Display(Name = "Клинический материал")]
            public int ClinicMaterialID { get; set; }

            [Display(Name = "Изолят")]
            public int OrganismTypeID { get; set; }

            [Required(ErrorMessage = "Обязательное поле")]
            [Display(Name = "Доктор")]
            public int DoctorID { get; set; }

            [Required(ErrorMessage = "Обязательное поле")]
            [Display(Name = "ЛПУ")]
            public int ClinicID { get; set; }


            [Display(Name = "Контракт для ЛПУ")]
            public int ClinicContractID { get; set; }

       
            [Display(Name = "Центр")]
            public int CenterProjectID { get; set; }


            [Display(Name = "Тип оплаты образца")]
            public int SamplePaymentTypeID { get; set; }

            [Display(Name = "Причина удаления")]
            public int RemoveReasonID { get; set; }

            [Display(Name = "№ Образце")]
            public int SampleNumber { get; set; }

            [StringLength(50, ErrorMessage = "Превышена максимальная длина")]
            [Display(Name = "№ лаборатории")]
            public string LabNumber { get; set; }

            [StringLength(50, ErrorMessage = "Превышена максимальная длина")]
            [Display(Name = "№ ИРК")]
            public string CardNumber { get; set; }

            [StringLength(50, ErrorMessage = "Превышена максимальная длина")]
            [Display(Name = "№ Центра")]
            public string NumberFromCenter { get; set; }

            [DisplayFormat(DataFormatString = " {0:dd/MM/yyyy hh:mm:ss}", ApplyFormatInEditMode = true, HtmlEncode = false)]
            [Required(ErrorMessage = "Обязательное поле")]
            [Display(Name = "Дата забора образца")]
            public decimal DatetimeCapture { get; set; }

            [DisplayFormat(DataFormatString = " {0:dd/MM/yyyy hh:mm:ss}", ApplyFormatInEditMode = true, HtmlEncode = false)]
            [Required(ErrorMessage = "Обязательное поле")]
            [Display(Name = "Дата доставки образца")]
            public decimal DatetimeDelivery { get; set; }

            [Display(Name = "Статус забора образца")]
            public bool IsSampleTaken { get; set; }

            [ConcurrencyCheck]
            [Timestamp]
            public Byte[] Timestamp { get; set; }
        }
    }

    [MetadataType(typeof(PatientMetadata))]
    public partial class Patient
    {
        public class PatientMetadata
        {
            public int PatientID { get; set; }

            [Display(Name = "Статус пациента")]
            [Required(ErrorMessage = "Обязательное поле")]
            public int PatientStatusTypeID { get; set; }

            [Display(Name = "Фамилия")]
            [StringLength(100, ErrorMessage = "Превышена максимальная длина")]
            [Required(ErrorMessage = "Обязательное поле")]
            public string Lastname { get; set; }

            [Display(Name = "Инициалы")]
            [StringLength(10, ErrorMessage = "Превышена максимальная длина")]
            [Required(ErrorMessage = "Обязательное поле")]
            public string Initials { get; set; }

            [Display(Name = "Дата рожд.")]
            [Required(ErrorMessage = "Обязательное поле")]
            [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
            public decimal Birthdate { get; set; }

            [Display(Name = "Пол")]
            [StringLength(10, ErrorMessage = "Превышена максимальная длина")]
            [Required(ErrorMessage = "Обязательное поле")]
            public string Sex { get; set; }

            [Display(Name = "Возраст")]
            public int Age { get; set; }

            [Display(Name = "№ ИРК")]
            [StringLength(1000, ErrorMessage = "Превышена максимальная длина")]
            public string CrfNumber { get; set; }

            [Display(Name = "№ ист.болезни")]
            [StringLength(1000, ErrorMessage = "Превышена максимальная длина")]
            public string CaseHistory { get; set; }

            [Display(Name = "Дата нач.заболев.")]
            [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
            public decimal InfectionDate { get; set; }

            [Display(Name = "Дата госпитализ.")]
            [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
            public decimal HospitalisationDate { get; set; }

            [Display(Name = "Дата выздоровл.")]
            [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
            public decimal DischargeDate { get; set; }

            [Display(Name = "Дата заполн. карты")]
            [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
            public decimal CardReadyDate { get; set; }

            [ConcurrencyCheck]
            [Timestamp]
            public Byte[] Timestamp { get; set; }
        }
    }



    [MetadataType(typeof(ClinicMetadata))]
    public partial class Clinic { }
    public class ClinicMetadata
    {
        public int ClinicID;

        [StringLength(1000, ErrorMessage = "Превышена максимальная длина")]
        [Display(Name = "Название")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Description { get; set; }

        [StringLength(10, ErrorMessage = "Превышена максимальная длина")]
        [Display(Name = "Код")]
        [Required(ErrorMessage = "Обязательное поле")]
        public decimal Code { get; set; }

        [Display(Name = "Клиника")]
        [Required(ErrorMessage = "Обязательное поле")]
        public int ClinicGroupID { get; set; }

        [ConcurrencyCheck]
        [Timestamp]
        public Byte[] Timestamp { get; set; }
    }
    [MetadataType(typeof(ContractMetadata))]
    public partial class Contract
    {

        //public virtual ICollection<ClinicsAndContract> ContractAndClinics { get; set; }
        //public virtual ICollection<Clinic> ContractClinics { get; set; }
        //public virtual ICollection<ContractsAndMBAnalysisType> ContractAndMBAnalysis { get; set; }
        //public virtual ICollection<MBAnalysi> ContractMBAnalysis { get; set; }


        public class ContractMetadata
        {
            public int ContractID;

            [StringLength(255, ErrorMessage = "Превышена максимальная длина")]
            [Display(Name = "Код")]
            [Required(ErrorMessage = "Обязательное поле")]
            public string Code { get; set; }

            [Display(Name = "Название")]
            [StringLength(255, ErrorMessage = "Превышена максимальная длина")]
            [Required(ErrorMessage = "Обязательное поле")]
            public string Description { get; set; }

            [Display(Name = "Регистрационный номер")]
            [StringLength(255, ErrorMessage = "Превышена максимальная длина")]
            [Required(ErrorMessage = "Обязательное поле")]
            public string AccountNumber { get; set; }

            [Display(Name = "Дата начала")]
            [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
            [Required(ErrorMessage = "Обязательное поле")]
            public decimal DateStart { get; set; }

            [Display(Name = "Дата окончания")]
            [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
            [Required(ErrorMessage = "Обязательное поле")]
            public decimal DateEnd { get; set; }

            [Display(Name = "Тип автоматизации")]
            [Required(ErrorMessage = "Обязательное поле")]
            public int IsAutoGenerate { get; set; }
        }
    }



    [MetadataType(typeof(AdditionalServiceMetadata))]
    public partial class AdditionalService { }
    public class AdditionalServiceMetadata
    {
        public int AdditionalServiceID;

        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Display(Name = "Описание (Рус.)")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Description { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:C}")]
        [Display(Name = "Цена")]
        [Required(ErrorMessage = "Обязательное поле")]
        public decimal Price { get; set; }

        [Display(Name = "Активная услуга")]
        [Required(ErrorMessage = "Обязательное поле")]
        public int IsInUse { get; set; }

        [ConcurrencyCheck]
        [Timestamp]
        public Byte[] Timestamp { get; set; }
    }

    [MetadataType(typeof(DiagnosisTypeMetadata))]
    public partial class DiagnosisType { }
    public class DiagnosisTypeMetadata
    {
        public int DiagnosisTypeID;

        [Display(Name = "Код")]
        [StringLength(5, ErrorMessage = "Превышена максимальная длина кода")]
        public string Code { get; set; }

        [Display(Name = "Описание (Англ.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionEng { get; set; }

        [Display(Name = "Описание (Рус.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionRus { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }
    }


    [MetadataType(typeof(AntibioticTypeMetadata))]
    public partial class AntibioticType { }
    public class AntibioticTypeMetadata
    {
        public int AntibioticTypeID;

        [Display(Name = "Код")]
        [StringLength(5, ErrorMessage = "Превышена максимальная длина кода")]
        public string Code { get; set; }

        [Display(Name = "Описание (Англ.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionEng { get; set; }

        [Display(Name = "Описание (Рус.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionRus { get; set; }

        [Timestamp]
        [ConcurrencyCheck]
        public Byte[] Timestamp { get; set; }
    }

    [MetadataType(typeof(ABTherapyTypeMetadata))]
    public partial class ABTherapyType { }
    public class ABTherapyTypeMetadata
    {
        public int ABTherapyTypeID;

        [Display(Name = "Код")]
        [StringLength(5, ErrorMessage = "Превышена максимальная длина кода")]
        public string Code { get; set; }

        [Display(Name = "Описание (Англ.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionEng { get; set; }

        [Display(Name = "Описание (Рус.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionRus { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }
    }

    [MetadataType(typeof(CityMetadata))]
    public partial class City { }
    public class CityMetadata
    {
        public int CityID;

        [Display(Name = "Код")]
        [StringLength(5, ErrorMessage = "Превышена максимальная длина кода")]
        public string Code { get; set; }

        [Display(Name = "Описание (Англ.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionEng { get; set; }

        [Display(Name = "Описание (Рус.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionRus { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }
    }

    [MetadataType(typeof(ClinicMaterialGroupMetadata))]
    public partial class ClinicMaterialGroup { }
    public class ClinicMaterialGroupMetadata
    {
        public int ClinicMaterialGroupID;

        [Display(Name = "Код")]
        [StringLength(5, ErrorMessage = "Превышена максимальная длина кода")]
        public string Code { get; set; }

        [Display(Name = "Описание (Англ.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionEng { get; set; }

        [Display(Name = "Описание (Рус.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionRus { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }
    }


    [MetadataType(typeof(CommentMetadata))]
    public partial class Comment { }
    public class CommentMetadata
    {
        public int CommentID;

        [Display(Name = "Код")]
        [StringLength(5, ErrorMessage = "Превышена максимальная длина кода")]
        public string Code { get; set; }

        [Display(Name = "Описание (Англ.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionEng { get; set; }

        [Display(Name = "Описание (Рус.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionRus { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }
    }

    [MetadataType(typeof(DiagnosisMetadata))]
    public partial class Diagnosis { }
    public class DiagnosisMetadata
    {
        public int DiagnosisID;

        [Display(Name = "Код")]
        [StringLength(5, ErrorMessage = "Превышена максимальная длина кода")]
        public string Code { get; set; }

        [Display(Name = "Описание (Англ.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionEng { get; set; }

        [Display(Name = "Описание (Рус.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionRus { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }
    }

    [MetadataType(typeof(DrugMetadata))]
    public partial class Drug { }
    public class DrugMetadata
    {
        public int DrugID;

        [Display(Name = "Код")]
        [StringLength(5, ErrorMessage = "Превышена максимальная длина кода")]
        public string Code { get; set; }

        [Display(Name = "Описание (Англ.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionEng { get; set; }

        [Display(Name = "Описание (Рус.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionRus { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }
    }

    [MetadataType(typeof(FenotypeMetadata))]
    public partial class Fenotype { }
    public class FenotypeMetadata
    {
        public int FenotypeID;

        [Display(Name = "Код")]
        [StringLength(5, ErrorMessage = "Превышена максимальная длина кода")]
        public string Code { get; set; }

        [Display(Name = "Описание (Англ.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionEng { get; set; }

        [Display(Name = "Описание (Рус.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionRus { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }
    }

    [MetadataType(typeof(FrequencyMetadata))]
    public partial class Frequency { }
    public class FrequencyMetadata
    {
        public int FrequencyID;

        [Display(Name = "Код")]
        [StringLength(5, ErrorMessage = "Превышена максимальная длина кода")]
        public string Code { get; set; }

        [Display(Name = "Описание (Англ.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionEng { get; set; }

        [Display(Name = "Описание (Рус.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionRus { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }
    }

    [MetadataType(typeof(HeavyMetadata))]
    public partial class Heavy { }
    public class HeavyMetadata
    {
        public int HeavyID;

        [Display(Name = "Код")]
        [StringLength(5, ErrorMessage = "Превышена максимальная длина кода")]
        public string Code { get; set; }

        [Display(Name = "Описание (Англ.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionEng { get; set; }

        [Display(Name = "Описание (Рус.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionRus { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }
    }

    [MetadataType(typeof(MBAnalysisResultMetadata))]
    public partial class MBAnalysisResult { }
    public class MBAnalysisResultMetadata
    {
        public int MBAnalysisResultID;

        [Display(Name = "Код")]
        [StringLength(5, ErrorMessage = "Превышена максимальная длина кода")]
        public string Code { get; set; }

        [Display(Name = "Описание (Англ.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionEng { get; set; }

        [Display(Name = "Описание (Рус.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionRus { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }
    }

    [MetadataType(typeof(MBBacterioscopyOrganismTypeMetadata))]
    public partial class MBBacterioscopyOrganismType { }
    public class MBBacterioscopyOrganismTypeMetadata
    {
        public int MBBacterioscoryOrganismTypeID;

        [Display(Name = "Код")]
        [StringLength(5, ErrorMessage = "Превышена максимальная длина кода")]
        public string Code { get; set; }

        [Display(Name = "Описание (Англ.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionEng { get; set; }

        [Display(Name = "Описание (Рус.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionRus { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }
    }


    [MetadataType(typeof(MBStatusMetadata))]
    public partial class MBStatus { }
    public class MBStatusMetadata
    {
        public int MBStatusID;

        [Display(Name = "Код")]
        [StringLength(5, ErrorMessage = "Превышена максимальная длина кода")]
        public string Code { get; set; }

        [Display(Name = "Описание (Англ.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionEng { get; set; }

        [Display(Name = "Описание (Рус.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionRus { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }
    }

    [MetadataType(typeof(MedicalFormMetadata))]
    public partial class MedicalForm { }
    public class MedicalFormMetadata
    {
        public int MedicalFormID;

        [Display(Name = "Код")]
        [StringLength(5, ErrorMessage = "Превышена максимальная длина кода")]
        public string Code { get; set; }

        [Display(Name = "Описание (Англ.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionEng { get; set; }

        [Display(Name = "Описание (Рус.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionRus { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }
    }

    [MetadataType(typeof(MedicalRouteMetadata))]
    public partial class MedicalRoute { }
    public class MedicalRouteMetadata
    {
        public int MedicalRouteID;

        [Display(Name = "Код")]
        [StringLength(5, ErrorMessage = "Превышена максимальная длина кода")]
        public string Code { get; set; }

        [Display(Name = "Описание (Англ.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionEng { get; set; }

        [Display(Name = "Описание (Рус.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionRus { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }
    }

    [MetadataType(typeof(MedicalUnitMetadata))]
    public partial class MedicalUnit { }
    public class MedicalUnitMetadata
    {
        public int MedicalUnitID;

        [Display(Name = "Код")]
        [StringLength(5, ErrorMessage = "Превышена максимальная длина кода")]
        public string Code { get; set; }

        [Display(Name = "Описание (Англ.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionEng { get; set; }

        [Display(Name = "Описание (Рус.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionRus { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }
    }

    [MetadataType(typeof(MethodMetadata))]
    public partial class MethodForm { }
    public class MethodMetadata
    {
        public int MethodID;

        [Display(Name = "Код")]
        [StringLength(5, ErrorMessage = "Превышена максимальная длина кода")]
        public string Code { get; set; }

        [Display(Name = "Описание (Англ.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionEng { get; set; }

        [Display(Name = "Описание (Рус.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionRus { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }
    }

    [MetadataType(typeof(OrganismTypeMetadata))]
    public partial class OrganismType { }
    public class OrganismTypeMetadata
    {
        public int OrganismTypeID;

        [Display(Name = "Код")]
        [StringLength(5, ErrorMessage = "Превышена максимальная длина кода")]
        public string Code { get; set; }

        [Display(Name = "Описание (Англ.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionEng { get; set; }

        [Display(Name = "Описание (Рус.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionRus { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }
    }

    [MetadataType(typeof(PatientCharNameMetadata))]
    public partial class PatientCharName { }
    public class PatientCharNameMetadata
    {
        public int MedicalFormID;

        [Display(Name = "Код")]
        [StringLength(5, ErrorMessage = "Превышена максимальная длина кода")]
        public string Code { get; set; }

        [Display(Name = "Описание (Англ.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionEng { get; set; }

        [Display(Name = "Описание (Рус.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionRus { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }
    }

    [MetadataType(typeof(PatientStatusTypeMetadata))]
    public partial class PatientStatusType { }
    public class PatientStatusTypeMetadata
    {
        public int PatientStatusTypeID;

        [Display(Name = "Код")]
        [StringLength(5, ErrorMessage = "Превышена максимальная длина кода")]
        public string Code { get; set; }

        [Display(Name = "Описание (Англ.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionEng { get; set; }

        [Display(Name = "Описание (Рус.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionRus { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }
    }

    [MetadataType(typeof(RemoveReasonMetadata))]
    public partial class RemoveReason { }
    public class RemoveReasonMetadata
    {
        public int RemoveReasonID;

        [Display(Name = "Код")]
        [StringLength(5, ErrorMessage = "Превышена максимальная длина кода")]
        public string Code { get; set; }

        [Display(Name = "Описание (Англ.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionEng { get; set; }

        [Display(Name = "Описание (Рус.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionRus { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }
    }

    [MetadataType(typeof(ROCharNameMetadata))]
    public partial class ROCharName { }
    public class ROCharNameMetadata
    {
        public int ROCharNameID;

        [Display(Name = "Код")]
        [StringLength(5, ErrorMessage = "Превышена максимальная длина кода")]
        public string Code { get; set; }

        [Display(Name = "Описание (Англ.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionEng { get; set; }

        [Display(Name = "Описание (Рус.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionRus { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }
    }

    [MetadataType(typeof(SamplePaymentTypeMetadata))]
    public partial class SamplePaymentType { }
    public class SamplePaymentTypeMetadata
    {
        public int SamplePaymentTypeID;

        [Display(Name = "Код")]
        [StringLength(5, ErrorMessage = "Превышена максимальная длина кода")]
        public string Code { get; set; }

        [Display(Name = "Описание (Англ.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionEng { get; set; }

        [Display(Name = "Описание (Рус.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionRus { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }
    }

    [MetadataType(typeof(DoctorMetadata))]
    public partial class Doctor { }
    public class DoctorMetadata
    {
        public int DoctorID;

        [Display(Name = "Фамилия")]
        [StringLength(100, ErrorMessage = "Превышена максимальная длина фамилии")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Lastname { get; set; }

        [Display(Name = "И.О.")]
        [StringLength(5, ErrorMessage = "Превышена максимальная длина инициалов")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Initials { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }
    }

    [MetadataType(typeof(LogicMetadata))]
    public partial class Logic { }
    public class LogicMetadata
    {
        public int LogicID;

        [Display(Name = "Описание (Англ.)")]
        [StringLength(100, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionEng { get; set; }

        [Display(Name = "Описание (Рус.)")]
        [StringLength(100, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionRus { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }
    }

    [MetadataType(typeof(MBAnalysisTypeMetadata))]
    public partial class MBAnalysisType { }
    public class MBAnalysisTypeMetadata
    {
        public int MBAnalysisTypeID;

        [Display(Name = "Код")]
        [StringLength(5, ErrorMessage = "Превышена максимальная длина кода")]
        public string Code { get; set; }

        [Display(Name = "Описание (Англ.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionEng { get; set; }

        [Display(Name = "Описание (Рус.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionRus { get; set; }

        [Display(Name = "Активный")]
        [Required(ErrorMessage = "Обязательное поле")]
        public int IsInUse { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }
    }


    [MetadataType(typeof(PaymentTypeMetadata))]
    public partial class PaymentType { }
    public class PaymentTypeMetadata
    {
        public int PaymentTypeID;

        [Display(Name = "Код")]
        [StringLength(5, ErrorMessage = "Превышена максимальная длина кода")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Code { get; set; }

        [Display(Name = "Описание")]
        [StringLength(100, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Description { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }
    }

    [MetadataType(typeof(ProjectMetadata))]
    public partial class Project { }
    public class ProjectMetadata
    {
        public int ProjectID;

        [Display(Name = "Описание (Англ.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionEng { get; set; }

        [Display(Name = "Описание (Рус.)")]
        [StringLength(255, ErrorMessage = "Превышена максимальная длина названия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string DescriptionRus { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }
    }

    [MetadataType(typeof(ValueMetadata))]
    public partial class Value { }
    public class ValueMetadata
    {
        public int ValueID;

        [Display(Name = "Значение")]
        [Required(ErrorMessage = "Обязательное поле")]
        public float ValueNumber { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }
    }
}