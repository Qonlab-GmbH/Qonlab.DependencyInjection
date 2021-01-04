using System;

namespace Qonlab.DependencyInjection.Abstractions {
    public class InjectAsRequestSingletonAttribute : InjectionRegistrationAttribute {
        public InjectAsRequestSingletonAttribute( params Type[] registeredInterfaces )
            : base( registeredInterfaces ) { }

        public InjectAsRequestSingletonAttribute() : base() { }
    }
}
