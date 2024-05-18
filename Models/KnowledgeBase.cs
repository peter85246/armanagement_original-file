using Microsoft.AspNetCore.Http;
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
    public class PostAllKnowledgeBase : PostId
    {
        public short IsCommon { get; set; } //0:取得網頁的；1:取得眼鏡的
        //public int MachineAddId { get; set; }
    }

    /// <summary>
    /// 新增知識 - 故障說明
    /// </summary>
    public class KnowledgeBase
    {
        public int KnowledgeBaseId { get; set; } // 流程流水號
        public short Deleted { get; set; } // 是否刪除
        public string KnowledgeBaseDeviceType { get; set; } = string.Empty; // 設備種類
        public string KnowledgeBaseDeviceParts { get; set; } = string.Empty; // 設備部件
        public string KnowledgeBaseRepairItems { get; set; } = string.Empty; // 維修項目
        public string KnowledgeBaseRepairType { get; set; } = string.Empty; // 維修類型
        public string KnowledgeBaseFileNo { get; set; } = string.Empty; // 檔案編號
        public string KnowledgeBaseAlarmCode { get; set; } = string.Empty; // 故障代碼
        public string KnowledgeBaseSpec { get; set; } = string.Empty; // 規格
        public string KnowledgeBaseSystem { get; set; } = string.Empty; // 系統
        public string KnowledgeBaseProductName { get; set; } = string.Empty; // 產品名稱
        public string KnowledgeBaseAlarmCause { get; set; } = string.Empty; // 故障發生原因
        public string KnowledgeBaseAlarmDesc { get; set; } = string.Empty; // 故障描述
        public string KnowledgeBaseAlarmOccasion { get; set; } = string.Empty; // 故障發生時機
        public string KnowledgeBaseModelImage { get; set; } = string.Empty; //Model機型圖片
        public IFormFile? KnowledgeBaseModelImageObj { get; set; } // Model機型圖片檔案
        public string KnowledgeBaseToolsImage { get; set; } = string.Empty; //所有使用工具圖片
        public IFormFile? KnowledgeBaseToolsImageObj { get; set; } // 所有使用工具圖片檔案
        public string KnowledgeBasePositionImage { get; set; } = string.Empty; //部位位置圖片
        public IFormFile? KnowledgeBasePositionImageObj { get; set; } // 部位位置圖片檔案

        public int MachineAddId { get; set; } //機台流水號
    }

    [BindNever]
    public class PostKnowledgeinfoFilter
    {
        public string Keyword { get; set; } = string.Empty; //關鍵字
    }

    /// <summary>
    /// 儲存故障流程
    /// </summary>
    public class PostSaveKnowledgeBase
    {
        public int MachineAddId { get; set; }
        public List<PostKnowledgeBase>? KnowledgeBases { get; set; }
    }

    /// <summary>
    /// 儲存單一故障流程
    /// </summary>
    public class PostKnowledgeBase
    {
        public int KnowledgeBaseId { get; set; } // 故障說明流水號
        public short? Deleted { get; set; } // 是否刪除
        public string? KnowledgeBaseDeviceType { get; set; } = string.Empty; // 設備種類
        public string? KnowledgeBaseDeviceParts { get; set; } = string.Empty; // 設備部件
        public string? KnowledgeBaseRepairItems { get; set; } = string.Empty; // 維修項目
        public string? KnowledgeBaseRepairType { get; set; } = string.Empty; // 維修類型
        public string? KnowledgeBaseFileNo { get; set; } = string.Empty; // 檔案編號
        public string? KnowledgeBaseAlarmCode { get; set; } = string.Empty; // 故障代碼
        public string? KnowledgeBaseSpec { get; set; } = string.Empty; // 規格
        public string? KnowledgeBaseSystem { get; set; } = string.Empty; // 系統
        public string? KnowledgeBaseProductName { get; set; } = string.Empty; // 產品名稱
        public string? KnowledgeBaseAlarmCause { get; set; } = string.Empty; // 故障發生原因
        public string? KnowledgeBaseAlarmDesc { get; set; } = string.Empty; // 故障描述
        public string? KnowledgeBaseAlarmOccasion { get; set; } = string.Empty; // 故障發生時機
        public string? KnowledgeBaseModelImage { get; set; } = string.Empty; //Model機型圖片
        public IFormFile? KnowledgeBaseModelImageObj { get; set; } // Model機型圖片檔案
        public bool IsDeletedKnowledgeBaseModelImage { get; set; } = false; //是否刪除Model機型圖片
        public string? KnowledgeBaseToolsImage { get; set; } = string.Empty; //所有使用工具圖片
        public IFormFile? KnowledgeBaseToolsImageObj { get; set; } // 所有使用工具圖片檔案
        public bool IsDeletedKnowledgeBaseToolsImage { get; set; } = false; //是否刪除所有使用工具圖片
        public string? KnowledgeBasePositionImage { get; set; } = string.Empty; //部位位置圖片
        public IFormFile? KnowledgeBasePositionImageObj { get; set; } // 部位位置圖片檔案
        public bool IsDeletedKnowledgeBasePositionImage { get; set; } = false; //是否刪除部位位置圖片
        //public int? Creator { get; set; } // 創建者
        //public DateTime? CreatedTime { get; set; } // 創建時間
        //public int? Updater { get; set; } // 更新者
        //public DateTime? UpdateTime { get; set; } // 更新時間
    }
}
