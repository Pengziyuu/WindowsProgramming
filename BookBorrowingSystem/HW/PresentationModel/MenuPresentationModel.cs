using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    public class MenuPresentationModel
    {
        private bool _isBorrowingButtonEnable = true;
        private bool _isInventoryButtonEnable = true;
        private bool _isManagementButtonEnable = true;

        public MenuPresentationModel()
        {
        }

        // 改變Borrow按鈕狀態
        public void ChangeBorrowingButtonState()
        {
            _isBorrowingButtonEnable = !_isBorrowingButtonEnable;
        }

        // 改變Inventory按鈕狀態
        public void ChangeInventoryButtonState()
        {
            _isInventoryButtonEnable = !_isInventoryButtonEnable;
        }

        // 改變Management按鈕狀態
        public void ChangeManagementButtonState()
        {
            _isManagementButtonEnable = !_isManagementButtonEnable;
        }

        // 回傳Borrow按鈕狀態
        public bool IsBorrowingButtonEnable()
        {
            return _isBorrowingButtonEnable;
        }

        // 回傳Inventory按鈕狀態
        public bool IsInventoryButtonEnable()
        {
            return _isInventoryButtonEnable;
        }

        // 回傳Management按鈕狀態
        public bool IsManagementButtonEnable()
        {
            return _isManagementButtonEnable;
        }
    }
}
