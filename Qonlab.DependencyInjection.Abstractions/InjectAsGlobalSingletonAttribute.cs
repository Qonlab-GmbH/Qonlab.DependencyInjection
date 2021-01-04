using System;

namespace Qonlab.DependencyInjection.Abstractions {
    public class InjectAsGlobalSingletonAttribute : InjectionRegistrationAttribute {

        public InjectAsGlobalSingletonAttribute( params Type[] registeredInterfaces )
            : base( registeredInterfaces ) { }

        public InjectAsGlobalSingletonAttribute() : base() { }
    }
}
