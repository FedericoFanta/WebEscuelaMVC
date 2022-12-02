using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebEscuelaMVCc.Validations
{
    public class CheckValidNum:ValidationAttribute
    {
        public CheckValidNum()
        {
            ErrorMessage="El número debe ser mayor a 100";
        }
        public override bool IsValid(object value)
        {
            int num = (int)value;
            if (num < 100)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}