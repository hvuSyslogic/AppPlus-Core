namespace Xy.Pis.Domain
{

    // BsItem
    public partial class BsItem
    {
        public BsItem()
        {
            LsGroupType = 1;
            PriceIn = 0.00m;
            PriceDiag = 0.00m;
            LsGfType = 2;
            OptionPrice = false;
            IsSpecSum = false;
            IsNew = true;
            IsOnlyForSys = false;
            IsRpForbid = false;
            IsChildAdd = false;
            IsBedFee = false;
            IsOpsAdd = false;
            LsfeeTurn = 1;
            LsAdviceType = 1;
            IsActive = true;
            IconIndex = 0;
            IsInoculate = false;
            PriceHighLine = 0.00m;
            LastTime = System.DateTime.Now;
            PriceSub = 0.00m;
            IsCitySum = true;
            InitializePartial();
        }

        partial void InitializePartial();

        ///<summary>
        /// 项目ID
        ///</summary>
        public int Id { get; set; } // ID (Primary key)
        ///<summary>
        /// 项目分类：1-药品；2-治疗；3-物资材料
        ///</summary>
        public short LsGroupType { get; set; } // LsGroupType
        ///<summary>
        /// 编码
        ///</summary>
        public string Code { get; set; } // Code (length: 20)
        ///<summary>
        /// 五笔码（固定）
        ///</summary>
        public string WbCode { get; set; } // WbCode (length: 20)
        ///<summary>
        /// 拼音码（固定）
        ///</summary>
        public string PyCode { get; set; } // PyCode (length: 20)
        ///<summary>
        /// 化学名五笔码
        ///</summary>
        public string StrokeCode { get; set; } // StrokeCode (length: 20)
        ///<summary>
        /// 化学名拼音码
        ///</summary>
        public string OtherCode { get; set; } // OtherCode (length: 20)
        ///<summary>
        /// 主组
        ///</summary>
        public int GroupMainId { get; set; } // GroupMainId
        ///<summary>
        /// 子组
        ///</summary>
        public int? GroupSubId { get; set; } // GroupSubId
        ///<summary>
        /// 简称
        ///</summary>
        public string Name { get; set; } // Name (length: 50)
        ///<summary>
        /// 全称
        ///</summary>
        public string LongDesc { get; set; } // LongDesc (length: 100)
        ///<summary>
        /// 英文名
        ///</summary>
        public string EngDesc { get; set; } // EngDesc (length: 100)
        ///<summary>
        /// 规格
        ///</summary>
        public string Spec { get; set; } // Spec (length: 50)
        ///<summary>
        /// 住院单位
        ///</summary>
        public int UnitInId { get; set; } // UnitInId
        ///<summary>
        /// 住院价格
        ///</summary>
        public decimal PriceIn { get; set; } // PriceIn
        ///<summary>
        /// 门诊单位
        ///</summary>
        public int UnitDiagId { get; set; } // UnitDiagId
        ///<summary>
        /// 门诊价格
        ///</summary>
        public decimal PriceDiag { get; set; } // PriceDiag
        ///<summary>
        /// 加成率
        ///</summary>
        public decimal AddPercent { get; set; } // AddPercent
        ///<summary>
        /// 处方项目：1-中成药；2-西药；3-中药；4-检验；5-检查；6-手术；7-治疗；8-床位；9-其他；10-
        ///</summary>
        public short LsRpType { get; set; } // LsRpType
        ///<summary>
        /// 用量
        ///</summary>
        public decimal Dosage { get; set; } // Dosage
        ///<summary>
        /// 服用单位
        ///</summary>
        public int? UnitTakeId { get; set; } // UnitTakeId
        ///<summary>
        /// 频率
        ///</summary>
        public int? FrequencyId { get; set; } // FrequencyId
        ///<summary>
        /// 用法
        ///</summary>
        public int? UsageId { get; set; } // UsageId
        ///<summary>
        /// 门诊收费类别
        ///</summary>
        public int FeeMzId { get; set; } // FeeMzId
        ///<summary>
        /// 住院收费类别
        ///</summary>
        public int FeeZyId { get; set; } // FeeZyId
        ///<summary>
        /// 公费类别：1-公费；2-自费；3-按固定自付比例
        ///</summary>
        public short LsGfType { get; set; } // LsGfType
        ///<summary>
        /// 固定的自付比例
        ///</summary>
        public decimal? GfFixDisc { get; set; } // GfFixDisc
        ///<summary>
        /// 国基
        ///</summary>
        public bool OptionPrice { get; set; } // OptionPrice
        ///<summary>
        /// 单位剂量
        ///</summary>
        public decimal LimitTotalMz { get; set; } // LimitTotalMz
        ///<summary>
        /// 住院计价最小用量
        ///</summary>
        public decimal LimitTotalZy { get; set; } // LimitTotalZy
        ///<summary>
        /// 公费限额类别
        ///</summary>
        public int TypeGfxeId { get; set; } // TypeGFXEId
        ///<summary>
        /// 省基
        ///</summary>
        public bool IsSpecSum { get; set; } // IsSpecSum
        public bool IsNew { get; set; } // IsNew
        ///<summary>
        /// 医院内部使用的项目
        ///</summary>
        public bool IsOnlyForSys { get; set; } // IsOnlyForSys
        ///<summary>
        /// 禁止临床开药
        ///</summary>
        public bool IsRpForbid { get; set; } // IsRpForbid
        ///<summary>
        /// 是否儿科加收20%
        ///</summary>
        public bool IsChildAdd { get; set; } // IsChildAdd
        ///<summary>
        /// 是否床位费
        ///</summary>
        public bool IsBedFee { get; set; } // IsBedFee
        ///<summary>
        /// 是否加收布类费用
        ///</summary>
        public bool IsOpsAdd { get; set; } // IsOpsAdd
        ///<summary>
        /// 限制使用地点：1-全部;2-门诊;3-住院(原意义：长期医嘱附加收费的周期：1-每次收费；2-每天收费；3-每周收费)
        ///</summary>
        public short LsfeeTurn { get; set; } // LsfeeTurn
        ///<summary>
        /// 医嘱类别：1-医嘱；2-附加收费
        ///</summary>
        public short LsAdviceType { get; set; } // LsAdviceType
        ///<summary>
        /// 执行科室
        ///</summary>
        public int? LocationId { get; set; } // LocationId
        ///<summary>
        /// EASILAB的PRICES表的对应CODE
        ///</summary>
        public int? LisCode { get; set; } // LISCode
        ///<summary>
        /// 封面图片
        ///</summary>
        public string CoverPicture { get; set; } // CoverPicture (length: 200)
        ///<summary>
        /// 说明书扫描图
        ///</summary>
        public string MemoPicture { get; set; } // MemoPicture (length: 200)
        ///<summary>
        /// 备注
        ///</summary>
        public string Memo { get; set; } // Memo (length: 3000)
        ///<summary>
        /// 有效标志
        ///</summary>
        public bool IsActive { get; set; } // IsActive
        public string F1 { get; set; } // F1 (length: 100)
        public string F2 { get; set; } // F2 (length: 100)
        public string F3 { get; set; } // F3 (length: 100)
        public string F4 { get; set; } // F4 (length: 100)
        public short IconIndex { get; set; } // IconIndex
        ///<summary>
        /// 按小时计费
        ///</summary>
        public bool? IsInoculate { get; set; } // IsInoculate
        ///<summary>
        /// 最高零售价
        ///</summary>
        public decimal? PriceHighLine { get; set; } // PriceHighLine
        ///<summary>
        /// 显示顺序
        ///</summary>
        public short? OrderBy { get; set; } // OrderBy
        ///<summary>
        /// 三级分组
        ///</summary>
        public int? GroupSubId2 { get; set; } // GroupSubId2
        ///<summary>
        /// 输入时间
        ///</summary>
        public System.DateTime? LastTime { get; set; } // LastTime
        ///<summary>
        /// 一级医院价格
        ///</summary>
        public decimal? PriceSub { get; set; } // PriceSub
        ///<summary>
        /// 对应基本检查
        ///</summary>
        public int? CheckId { get; set; } // CheckId
        ///<summary>
        /// 对应基本护理
        ///</summary>
        public int? NurseId { get; set; } // NurseId
        ///<summary>
        /// 对应基本治疗
        ///</summary>
        public int? CureId { get; set; } // CureId
        ///<summary>
        /// 药典ID
        ///</summary>
        public int? DrugId { get; set; } // DrugID
        public int? CopyId { get; set; } // CopyId
        ///<summary>
        /// 门诊计价最小用量
        ///</summary>
        public int? MzUnitTotal { get; set; } // MzUnitTotal
        public int? ZyUnitTotal { get; set; } // ZyUnitTotal
        ///<summary>
        /// 是否门特用药
        ///</summary>
        public bool? IsMtDrug { get; set; } // IsMtDrug
        public string PackageSpec { get; set; } // PackageSpec (length: 100)
        ///<summary>
        /// 是否市基
        ///</summary>
        public bool IsCitySum { get; set; } // IsCitySum

        
        public virtual BsLocation BsLocation { get; set; } // FK_BsItem_BsLocation
    }

}
