using System;

namespace Qonlab.DependencyInjection.Abstractions {

    [System.AttributeUsage( System.AttributeTargets.Class, AllowMultiple = false, Inherited = false )]
    public class InjectionExplicitOverrideAttribute : Attribute {

        public Type[] OverriddenTypes { get; private set; }

        public InjectionExplicitOverrideAttribute( params Type[] overriddenTypes ) {
            OverriddenTypes = overriddenTypes;
        }
    }
}
