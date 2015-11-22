using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonsterHunterTool.Models.Common
{
    /// <summary>
    /// クエスト情報クラス
    /// </summary>
    public class QuestInfo
    {

        public QuestInfo()
        {
            Remark = new List<string>();
        }

        /// <summary>
        /// クエストレベル
        /// </summary>
        public string Level { get; set; }
        /// <summary>
        /// クエスト名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 場所
        /// </summary>
        public string Place { get; set; }
        /// <summary>
        /// クエスト内容
        /// </summary>
        public string Target { get; set; }
        /// <summary>
        /// サブターゲット
        /// </summary>
        public string SubTarget { get; set; }
        /// <summary>
        /// その他出現モンスター
        /// </summary>
        public string OtherMonster { get; set; }
        /// <summary>
        /// クエスト情報
        /// </summary>
        public string Infomation { get; set; }

        /// <summary>
        /// 備考
        /// </summary>
        public List<string> Remark { get; set; }
    }
}