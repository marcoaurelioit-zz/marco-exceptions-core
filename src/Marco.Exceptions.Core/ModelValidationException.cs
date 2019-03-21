using System;
using System.Runtime.Serialization;

namespace Marco.Exceptions.Core
{
    [Serializable]
    public class ModelValidationException : CoreException<ModelValidationError>
    {
        public override string Key => "ModelValidationException";

        public ModelValidationException()
        {
        }

        public ModelValidationException(params ModelValidationError[] errors)
        {
            AddError(errors);
        }

        protected ModelValidationException(SerializationInfo info, StreamingContext context) 
            : base(info, context)
        {
        }
    }
}