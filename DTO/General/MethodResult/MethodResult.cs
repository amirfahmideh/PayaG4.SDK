using System;
using System.Collections.Generic;

namespace PayaG4.SDK.DTO.General.MethodResults
{
    public class MethodResult<T>
    {
        public MethodResult() { }
        public MethodResult(T result)
        {
            Result = result;
        }
        public CRUDResultModel ResultModel { get; set; }
        public T Result { get; set; }

        public static MethodResult<T> CloneAccessDeniedPermissionMethodResult()
        {
            var errorMessage = CRUDResultModel.GetDefaultMessage(CRUDResultEnum.AccessDenied);
            var methodError = new MethodError(401, errorMessage, errorMessage);
            return new MethodResult<T>
            {
                Result = default,
                ResultModel = new CRUDResultModel(CRUDResultEnum.Error)
                {
                    Errors = new MethodError[] { methodError }
                }
            };
        }
        public static MethodResult<T> CloneExceptionMethodResult(Exception e)
        {
            var errorMessage = e?.InnerException?.Message ?? e.Message;
            var methodError = new MethodError(500, errorMessage, errorMessage);
            return new MethodResult<T>
            {
                Result = default,
                ResultModel = new CRUDResultModel(CRUDResultEnum.Error)
                {
                    Errors = new MethodError[] { methodError }
                }
            };
        }
        public static MethodResult<T> CloneMethodErrorsMethodResult(List<MethodError> methodErrors)
        {
            return new MethodResult<T>
            {
                Result = default,
                ResultModel = new CRUDResultModel(CRUDResultEnum.Error)
                {
                    Errors = methodErrors
                }
            };
        }
        public static MethodResult<T> CloneSimpleErrorMethodResult(string errorTitle, string errorDescription)
        {
            return new MethodResult<T>
            {
                Result = default,
                ResultModel = new CRUDResultModel()
                {
                    Type = CRUDResultEnum.Error,
                    Errors = [ new MethodError() {
                        Code  = 1,
                        Title = errorTitle,
                        Description = errorDescription
                        }
                    ]
                }
            };
        }
    }
}
