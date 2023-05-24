using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class BookManagementPresentationModel
    {
        private bool _isAddButtonEnable = false;
        private bool _isBrowseButtonEnable = false;
        private bool _isSaveButtonEnable = false;
        private bool _isName = false;
        private bool _isNumber = false;
        private bool _isPeople = false;
        private bool _isCategory = false;
        private bool _isPublish = false;
        private bool _isSource = false;
        public BookManagementPresentationModel()
        {
        }

        // 全部禁用
        public void DisableAll()
        {
            _isName = false;
            _isNumber = false;
            _isPeople = false;
            _isCategory = false;
            _isPublish = false;
            _isSource = false;
            _isBrowseButtonEnable = false;
        }

        // 全部啟用
        public void EnableAll()
        {
            _isName = true;
            _isNumber = true;
            _isPeople = true;
            _isCategory = true;
            _isPublish = true;
            _isSource = true;
            _isBrowseButtonEnable = true;
        }

        // 啟用儲存按鈕
        public void EnableSaveButtonEnable()
        {
            _isSaveButtonEnable = true;
        }

        // 禁用儲存按鈕
        public void DisableSaveButtonEnable()
        {
            _isSaveButtonEnable = false;
        }

        // 是否新增書籍啟用
        public bool IsAddButtonEnable()
        {
            return _isAddButtonEnable; 
        }

        // 是否瀏覽啟用
        public bool IsBrowseButtonEnable()
        {
            return _isBrowseButtonEnable;
        }

        // 是否儲存啟用
        public bool IsSaveButtonEnable()
        {
            return _isSaveButtonEnable;
        }

        // 是否書籍名稱啟用
        public bool IsNameEnable()
        {
            return _isName;
        }

        // 是否書籍編號啟用
        public bool IsNumberEnable()
        {
            return _isNumber;
        }

        // 是否書籍作者啟用
        public bool IsPeopleEnable()
        {
            return _isPeople;
        }

        // 是否書籍類別啟用
        public bool IsCategoryEnable()
        {
            return _isCategory;
        }

        // 是否出版項啟用
        public bool IsPublishEnable()
        {
            return _isPublish;
        }

        // 是否圖片路徑啟用
        public bool IsSourceEnable()
        {
            return _isSource;
        }
    }
}
