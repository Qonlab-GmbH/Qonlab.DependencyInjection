using System;

namespace Qonlab.DependencyInjection.Abstractions {

    [System.AttributeUsage( System.AttributeTargets.Class, AllowMultiple = false, Inherited = false )]
    public abstract class InjectionEnumRestrictionAttribute : Attribute {

        public object[] ValidEnumValues { get; protected set; }
        
    }
}
