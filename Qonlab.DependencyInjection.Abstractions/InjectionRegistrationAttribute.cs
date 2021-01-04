using System;

namespace Qonlab.DependencyInjection.Abstractions {
    [System.AttributeUsage( System.AttributeTargets.Class, AllowMultiple = true, Inherited = false )]
    public abstract class InjectionRegistrationAttribute : Attribute {
        public Type[] RegisteredInterfaces { get; private set; }

        protected InjectionRegistrationAttribute( params Type[] registeredInterfaces ) {
            this.RegisteredInterfaces = registeredInterfaces;
        }

        protected InjectionRegistrationAttribute() {
            this.RegisteredInterfaces = new Type[] { };
        }
    }
}
