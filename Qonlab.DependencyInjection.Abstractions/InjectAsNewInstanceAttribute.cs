using System;

namespace Qonlab.DependencyInjection.Abstractions {
    public class InjectAsNewInstanceAttribute : InjectionRegistrationAttribute {

        public InjectAsNewInstanceAttribute( params Type[] registeredInterfaces )
            : base( registeredInterfaces ) { }

        public InjectAsNewInstanceAttribute() : base() { }
    }
}
