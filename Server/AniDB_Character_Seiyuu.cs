﻿using Shoko.Models;

namespace Shoko.Models.Server
{
    public class AniDB_Character_Seiyuu
    {
        #region Server DB columns

        public int AniDB_Character_SeiyuuID { get; private set; }
        public int CharID { get; set; }
        public int SeiyuuID { get; set; }

        #endregion
    }
}