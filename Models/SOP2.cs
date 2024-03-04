using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 取得所有SOP資料
    /// </summary>
    [BindNever]
    public class PostAllSOP2 : PostId
    {
        public short IsCommon { get; set; } //0:取得網頁的；1:取得眼鏡的
    }

    /// <summary>
    /// 故障流程
    /// </summary>
    public class SOP2
    {
        public int SOP2Id { get; set; } // 流程流水號
        public short Deleted { get; set; } // 是否刪除
        public int SOP2Step { get; set; } // 流程步驟
        public string SOP2Message { get; set; } // 步驟說明
        public string SOP2Image { get; set; } = string.Empty; //步驟圖片
        public IFormFile? SOP2ImageObj { get; set; } // 步驟圖片檔案
        public string SOP2Remark { get; set; } // 備註補充
        public string SOP2RemarkImage { get; set; } = string.Empty; //備註圖片
        public IFormFile? SOP2RemarkImageObj { get; set; } // 備註圖片檔案
        public string SOP2Name { get; set; } // SOP名稱

        public int MachineAddId { get; set; } //機台流水號
        public int KnowledgeBaseId { get; set; } // 知識庫ID
    }


    /// <summary>
    /// 儲存故障流程
    /// </summary>
    public class PostSaveSOP2
    {
        public int MachineAddId { get; set; }
        public List<PostSOP2>? SOP2s { get; set; }

    }

    /// <summary>
    /// 儲存單一故障流程
    /// </summary>
    public class PostSOP2
    {
        public int SOP2Id { get; set; } // 流程流水號
        public short? Deleted { get; set; } // 是否刪除
        public int SOP2Step { get; set; } // 流程步驟
        public string? SOP2Message { get; set; } = string.Empty; // 步驟說明
        public string? SOP2Image { get; set; } = string.Empty; //步驟圖片
        public IFormFile? SOP2ImageObj { get; set; } // 步驟圖片檔案
        public bool IsDeletedSOP2Image { get; set; } = false; //是否刪除步驟圖片
        public string? SOP2Remark { get; set; } = string.Empty; // 備註補充
        public string? SOP2RemarkImage { get; set; } = string.Empty; //備註圖片
        public IFormFile? SOP2RemarkImageObj { get; set; } // 備註圖片檔案
        public bool IsDeletedSOP2RemarkImage { get; set; } = false; //是否刪除步驟圖片
        public string? SOP2Name { get; set; } = string.Empty; // SOP名稱
        public int? KnowledgeBaseId { get; set; } = null; // 知識庫ID
        //public int? Creator { get; set; } // 創建者
        //public DateTime? CreatedTime { get; set; } // 創建時間
        //public int? Updater { get; set; } // 更新者
        //public DateTime? UpdateTime { get; set; } // 更新時間
    }


}
