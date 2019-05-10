namespace JsonDataMaker.Core.DomainObjects
{
    public class GW0008RequestObject
    {
        /// <summary>
        /// ファイルID
        /// </summary>
        public int FileId { get; set; }
        /// <summary>
        /// 店番
        /// </summary>
        public int temban { get; set; }
        /// <summary>
        /// 科目コード
        /// </summary>
        public int kamokuCode { get; set; }
        /// <summary>
        /// 口座番号
        /// </summary>
        public int kozabango { get; set; }
        /// <summary>
        /// 過振区分
        /// </summary>
        public int kaburiKubun { get; set; }
        /// <summary>
        /// 契約者ID
        /// </summary>
        public int keiyakushaId { get; set; }
    }
}
