namespace Xy.Pis.Domain
{

    // BsLocation
    public partial class BsLocationDTO
    {
        public BsLocationDTO()
        {
            IsForwomen = false;
            PhoneCode = "0";
            IsActive = true;
            IconIndex = 0;
            BsItems = new System.Collections.Generic.List<BsItem>();
            InitializePartial();
        }

        partial void InitializePartial();
        public int Id { get; set; } // ID (Primary key)
        public string Code { get; set; } // Code (length: 6)
        public string Name { get; set; } // Name (length: 30)
        ///<summary>
        /// 所属分院
        ///</summary>
        public int? HospitalId { get; set; } // HospitalId
        ///<summary>
        /// 1-住院科室;2-门诊科室;3-所有业务科室;4-后勤科室;5-大科室;6-医技科室;7-药剂科室;8-物资仓库
        ///</summary>
        public short LsInOut { get; set; } // LsInOut
        ///<summary>
        /// 1-女性科室
        ///</summary>
        public bool IsForwomen { get; set; } // IsForwomen
        ///<summary>
        /// 1-CT；2-DR；3-MR；4-CR；5-RF；6-US；7-脑电图；8-心电图；9-镜检查；10-MG；11-DSA
        ///</summary>
        public string PhoneCode { get; set; } // PhoneCode (length: 20)
        ///<summary>
        /// 控制药比
        ///</summary>
        public decimal MedicineRatio { get; set; } // MedicineRatio
        public short OrderBy { get; set; } // OrderBy
        public bool IsActive { get; set; } // IsActive
        public string F1 { get; set; } // F1 (length: 100)
        public string F2 { get; set; } // F2 (length: 100)
        ///<summary>
        /// 1-挂号到科室，则全科室所有医生都能看诊
        ///</summary>
        public string F3 { get; set; } // F3 (length: 100)
        public string F4 { get; set; } // F4 (length: 100)
        public short IconIndex { get; set; } // IconIndex
        ///<summary>
        /// 科室专业
        ///</summary>
        public int? SpecialityId { get; set; } // SpecialityId
        ///<summary>
        /// 床位编制数
        ///</summary>
        public short? BedSum { get; set; } // BedSum
        ///<summary>
        /// 病案编码
        ///</summary>
        public string BaSysCode { get; set; } // BaSysCode (length: 50)
        ///<summary>
        /// 科室主任
        ///</summary>
        public string Director { get; set; } // Director (length: 50)
        public int? DeptTypeId { get; set; } // DeptTypeId
        ///<summary>
        /// 参与成本分摊标志
        ///</summary>
        public bool? IsCostApp { get; set; } // IsCostApp
        ///<summary>
        /// 科室分摊级别
        ///</summary>
        public short? AppLevel { get; set; } // AppLevel
        public string PyCode { get; set; } // PyCode (length: 10)
        ///<summary>
        /// 五笔码
        ///</summary>
        public string WbCode { get; set; } // WbCode (length: 6)
        ///<summary>
        /// 面积
        ///</summary>
        public int? Area { get; set; } // Area
        public string F5 { get; set; } // F5 (length: 100)
        public string F6 { get; set; } // F6 (length: 100)
        public string F7 { get; set; } // F7 (length: 100)
        public string F8 { get; set; } // F8 (length: 100)
        ///<summary>
        /// 门诊药房
        ///</summary>
        public int? OuRoomId { get; set; } // OuRoomId
        ///<summary>
        /// 住院药房
        ///</summary>
        public int? InRoomId { get; set; } // InRoomId
        ///<summary>
        /// 是否特殊价格
        ///</summary>
        public bool? IsPriceSub { get; set; } // IsPriceSub

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<BsItem> BsItems { get; set; } // BsItem.FK_BsItem_BsLocation
    }

}
