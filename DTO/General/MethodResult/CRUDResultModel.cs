using System.Collections.Generic;

namespace PayaG4.SDK.DTO.General.MethodResults
{
    public class CRUDResultModel
    {
        public CRUDResultEnum Type { get; set; }
        public string TypeString => Type.ToString();
        public int TypeNumber => (int)Type;
        public string Message { get; set; }
        public int? MessageCode { get; set; }
        public IEnumerable<MethodError> Errors { get; set; } = null;
        public CRUDResultModel()
        {

        }
        public CRUDResultModel(CRUDResultEnum type)
        {
            Type = type;
            Message = GetDefaultMessage(type);
        }
        public CRUDResultModel(CRUDResultEnum type, IEnumerable<MethodError> errors)
        {
            Type = type;
            Errors = errors;
            Message = GetDefaultMessage(type);
        }
        public static string GetDefaultMessage(CRUDResultEnum type)
        {
            switch (type)
            {
                case CRUDResultEnum.Success:
                    return "عملیات با موفقیت انجام شده است";
                case CRUDResultEnum.SuccessWithWarning:
                    return "در اجرای عملیات خطایی رخداده است";
                case CRUDResultEnum.UnknownError:
                    return "خطای ناشناخطه ای رخداده است";
                case CRUDResultEnum.Error:
                    return "خطایی در سیستم رخداده است";
                case CRUDResultEnum.AccessDenied:
                    return "مجوز اجرای عملیات را ندارید";
                default:
                    return string.Empty;
            }
        }
    }
}
