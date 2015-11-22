using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonsterHunterTool.Models.Common
{
    /// <summary>
    /// プレイヤー情報クラス
    /// </summary>
    public class PlayerInfo
    {
        /// <summary>
        /// プレイヤー名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 使用武器
        /// </summary>
        public string Weapon { get; set; }
    }
}