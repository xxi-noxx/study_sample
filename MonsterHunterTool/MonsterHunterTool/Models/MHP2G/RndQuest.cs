using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using MonsterHunterTool.Models.Common;

namespace MonsterHunterTool.Models.MHP2G
{
    public class RndQuest
    {
        public RndQuest()
        {
            Player = new List<PlayerInfo>();
            Quest = new QuestInfo();
        }
        /// <summary>
        /// ［クエスト種別］狩猟
        /// </summary>
        [DisplayName("狩猟（古龍含む）")]
        public bool QuestTypeHunt { get; set; }
        /// <summary>
        /// ［クエスト種別］大連続
        /// </summary>
        public bool QuestTypeContinue { get; set; }
        /// <summary>
        /// ［クエスト種別］討伐
        /// </summary>
        public bool QuestTypeSubjugation { get; set; }
        
        /// <summary>
        /// プレイヤー情報
        /// </summary>
        public List<PlayerInfo> Player { get; set; }
        /// <summary>
        /// クエスト情報
        /// </summary>
        public QuestInfo Quest { get; set; }
        

    }
}