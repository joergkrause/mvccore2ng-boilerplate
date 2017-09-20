﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference2
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserDto", Namespace="http://schemas.datacontract.org/2004/07/JoergIsAGeek.Workshop.Enterprise.DataTran" +
        "sferObjects.Authentication")]
    public partial class UserDto : object
    {
        
        private string EmailField;
        
        private string FirstNameField;
        
        private int IdField;
        
        private string LastNameField;
        
        private string LocationField;
        
        private string PasswordField;
        
        private string UserNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName
        {
            get
            {
                return this.FirstNameField;
            }
            set
            {
                this.FirstNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName
        {
            get
            {
                return this.LastNameField;
            }
            set
            {
                this.LastNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Location
        {
            get
            {
                return this.LocationField;
            }
            set
            {
                this.LocationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password
        {
            get
            {
                return this.PasswordField;
            }
            set
            {
                this.PasswordField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName
        {
            get
            {
                return this.UserNameField;
            }
            set
            {
                this.UserNameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="IdentityResult", Namespace="http://schemas.datacontract.org/2004/07/JoergIsAGeek.Workshop.Enterprise.Business" +
        "LogicLayer.Authentication")]
    public partial class IdentityResult : object
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="IdentityRoleDto", Namespace="http://schemas.datacontract.org/2004/07/JoergIsAGeek.Workshop.Enterprise.DataTran" +
        "sferObjects.Authentication")]
    public partial class IdentityRoleDto : object
    {
        
        private int IdField;
        
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.joergkrause.de/srv", ConfigurationName="ServiceReference2.AuthSrv")]
    public interface AuthSrv
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.joergkrause.de/srv/AuthSrv/CreateUser", ReplyAction="http://www.joergkrause.de/srv/AuthSrv/CreateUserResponse")]
        System.Threading.Tasks.Task<ServiceReference2.IdentityResult> CreateUserAsync(ServiceReference2.UserDto user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.joergkrause.de/srv/AuthSrv/FindUserById", ReplyAction="http://www.joergkrause.de/srv/AuthSrv/FindUserByIdResponse")]
        System.Threading.Tasks.Task<ServiceReference2.UserDto> FindUserByIdAsync(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.joergkrause.de/srv/AuthSrv/FindUserByName", ReplyAction="http://www.joergkrause.de/srv/AuthSrv/FindUserByNameResponse")]
        System.Threading.Tasks.Task<ServiceReference2.UserDto> FindUserByNameAsync(string normalizedUserName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.joergkrause.de/srv/AuthSrv/GetNormalizedUserName", ReplyAction="http://www.joergkrause.de/srv/AuthSrv/GetNormalizedUserNameResponse")]
        System.Threading.Tasks.Task<string> GetNormalizedUserNameAsync(ServiceReference2.UserDto user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.joergkrause.de/srv/AuthSrv/GetUserDtoId", ReplyAction="http://www.joergkrause.de/srv/AuthSrv/GetUserDtoIdResponse")]
        System.Threading.Tasks.Task<int> GetUserDtoIdAsync(ServiceReference2.UserDto user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.joergkrause.de/srv/AuthSrv/GetUserDtoName", ReplyAction="http://www.joergkrause.de/srv/AuthSrv/GetUserDtoNameResponse")]
        System.Threading.Tasks.Task<string> GetUserDtoNameAsync(ServiceReference2.UserDto user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.joergkrause.de/srv/AuthSrv/SetNormalizedUserName", ReplyAction="http://www.joergkrause.de/srv/AuthSrv/SetNormalizedUserNameResponse")]
        System.Threading.Tasks.Task SetNormalizedUserNameAsync(ServiceReference2.UserDto user, string normalizedName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.joergkrause.de/srv/AuthSrv/SeUserDtoName", ReplyAction="http://www.joergkrause.de/srv/AuthSrv/SeUserDtoNameResponse")]
        System.Threading.Tasks.Task SeUserDtoNameAsync(ServiceReference2.UserDto user, string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.joergkrause.de/srv/AuthSrv/UpdateUser", ReplyAction="http://www.joergkrause.de/srv/AuthSrv/UpdateUserResponse")]
        System.Threading.Tasks.Task<ServiceReference2.IdentityResult> UpdateUserAsync(ServiceReference2.UserDto user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.joergkrause.de/srv/AuthSrv/CreateRole", ReplyAction="http://www.joergkrause.de/srv/AuthSrv/CreateRoleResponse")]
        System.Threading.Tasks.Task<ServiceReference2.IdentityResult> CreateRoleAsync(ServiceReference2.IdentityRoleDto role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.joergkrause.de/srv/AuthSrv/DeleteRole", ReplyAction="http://www.joergkrause.de/srv/AuthSrv/DeleteRoleResponse")]
        System.Threading.Tasks.Task<ServiceReference2.IdentityResult> DeleteRoleAsync(ServiceReference2.IdentityRoleDto role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.joergkrause.de/srv/AuthSrv/FindRoleById", ReplyAction="http://www.joergkrause.de/srv/AuthSrv/FindRoleByIdResponse")]
        System.Threading.Tasks.Task<ServiceReference2.IdentityRoleDto> FindRoleByIdAsync(int roleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.joergkrause.de/srv/AuthSrv/FindRoleByName", ReplyAction="http://www.joergkrause.de/srv/AuthSrv/FindRoleByNameResponse")]
        System.Threading.Tasks.Task<ServiceReference2.IdentityRoleDto> FindRoleByNameAsync(string normalizedRoleName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.joergkrause.de/srv/AuthSrv/GetNormalizedRoleName", ReplyAction="http://www.joergkrause.de/srv/AuthSrv/GetNormalizedRoleNameResponse")]
        System.Threading.Tasks.Task<string> GetNormalizedRoleNameAsync(ServiceReference2.IdentityRoleDto role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.joergkrause.de/srv/AuthSrv/GetIdentityRoleDtoId", ReplyAction="http://www.joergkrause.de/srv/AuthSrv/GetIdentityRoleDtoIdResponse")]
        System.Threading.Tasks.Task<int> GetIdentityRoleDtoIdAsync(ServiceReference2.IdentityRoleDto role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.joergkrause.de/srv/AuthSrv/GetIdentityRoleDtoName", ReplyAction="http://www.joergkrause.de/srv/AuthSrv/GetIdentityRoleDtoNameResponse")]
        System.Threading.Tasks.Task<string> GetIdentityRoleDtoNameAsync(ServiceReference2.IdentityRoleDto role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.joergkrause.de/srv/AuthSrv/SetNormalizedRoleName", ReplyAction="http://www.joergkrause.de/srv/AuthSrv/SetNormalizedRoleNameResponse")]
        System.Threading.Tasks.Task SetNormalizedRoleNameAsync(ServiceReference2.IdentityRoleDto role, string normalizedName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.joergkrause.de/srv/AuthSrv/SeIdentityRoleDtoName", ReplyAction="http://www.joergkrause.de/srv/AuthSrv/SeIdentityRoleDtoNameResponse")]
        System.Threading.Tasks.Task SeIdentityRoleDtoNameAsync(ServiceReference2.IdentityRoleDto role, string roleName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.joergkrause.de/srv/AuthSrv/UpdateRole", ReplyAction="http://www.joergkrause.de/srv/AuthSrv/UpdateRoleResponse")]
        System.Threading.Tasks.Task<ServiceReference2.IdentityResult> UpdateRoleAsync(ServiceReference2.IdentityRoleDto role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.joergkrause.de/srv/AuthSrv/GetPasswordHash", ReplyAction="http://www.joergkrause.de/srv/AuthSrv/GetPasswordHashResponse")]
        System.Threading.Tasks.Task<string> GetPasswordHashAsync(ServiceReference2.UserDto userDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.joergkrause.de/srv/AuthSrv/HasPassword", ReplyAction="http://www.joergkrause.de/srv/AuthSrv/HasPasswordResponse")]
        System.Threading.Tasks.Task<bool> HasPasswordAsync(ServiceReference2.UserDto userDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.joergkrause.de/srv/AuthSrv/SetPasswordHash", ReplyAction="http://www.joergkrause.de/srv/AuthSrv/SetPasswordHashResponse")]
        System.Threading.Tasks.Task SetPasswordHashAsync(ServiceReference2.UserDto userDto, string passwordHash);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.joergkrause.de/srv/AuthSrv/FindByEmail", ReplyAction="http://www.joergkrause.de/srv/AuthSrv/FindByEmailResponse")]
        System.Threading.Tasks.Task<ServiceReference2.UserDto> FindByEmailAsync(string normalizedEmail);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.joergkrause.de/srv/AuthSrv/GetEmail", ReplyAction="http://www.joergkrause.de/srv/AuthSrv/GetEmailResponse")]
        System.Threading.Tasks.Task<string> GetEmailAsync(ServiceReference2.UserDto user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.joergkrause.de/srv/AuthSrv/GetEmailConfirmed", ReplyAction="http://www.joergkrause.de/srv/AuthSrv/GetEmailConfirmedResponse")]
        System.Threading.Tasks.Task<bool> GetEmailConfirmedAsync(ServiceReference2.UserDto user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.joergkrause.de/srv/AuthSrv/GetNormalizedEmail", ReplyAction="http://www.joergkrause.de/srv/AuthSrv/GetNormalizedEmailResponse")]
        System.Threading.Tasks.Task<string> GetNormalizedEmailAsync(ServiceReference2.UserDto user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.joergkrause.de/srv/AuthSrv/SetEmail", ReplyAction="http://www.joergkrause.de/srv/AuthSrv/SetEmailResponse")]
        System.Threading.Tasks.Task SetEmailAsync(ServiceReference2.UserDto user, string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.joergkrause.de/srv/AuthSrv/SetEmailConfirmed", ReplyAction="http://www.joergkrause.de/srv/AuthSrv/SetEmailConfirmedResponse")]
        System.Threading.Tasks.Task SetEmailConfirmedAsync(ServiceReference2.UserDto user, bool confirmed);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.joergkrause.de/srv/AuthSrv/SetNormalizedEmail", ReplyAction="http://www.joergkrause.de/srv/AuthSrv/SetNormalizedEmailResponse")]
        System.Threading.Tasks.Task SetNormalizedEmailAsync(ServiceReference2.UserDto user, string normalizedEmail);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    public interface AuthSrvChannel : ServiceReference2.AuthSrv, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    public partial class AuthSrvClient : System.ServiceModel.ClientBase<ServiceReference2.AuthSrv>, ServiceReference2.AuthSrv
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public AuthSrvClient() : 
                base(AuthSrvClient.GetDefaultBinding(), AuthSrvClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_AuthSrv.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AuthSrvClient(EndpointConfiguration endpointConfiguration) : 
                base(AuthSrvClient.GetBindingForEndpoint(endpointConfiguration), AuthSrvClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AuthSrvClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(AuthSrvClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AuthSrvClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(AuthSrvClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AuthSrvClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<ServiceReference2.IdentityResult> CreateUserAsync(ServiceReference2.UserDto user)
        {
            return base.Channel.CreateUserAsync(user);
        }
        
        public System.Threading.Tasks.Task<ServiceReference2.UserDto> FindUserByIdAsync(int userId)
        {
            return base.Channel.FindUserByIdAsync(userId);
        }
        
        public System.Threading.Tasks.Task<ServiceReference2.UserDto> FindUserByNameAsync(string normalizedUserName)
        {
            return base.Channel.FindUserByNameAsync(normalizedUserName);
        }
        
        public System.Threading.Tasks.Task<string> GetNormalizedUserNameAsync(ServiceReference2.UserDto user)
        {
            return base.Channel.GetNormalizedUserNameAsync(user);
        }
        
        public System.Threading.Tasks.Task<int> GetUserDtoIdAsync(ServiceReference2.UserDto user)
        {
            return base.Channel.GetUserDtoIdAsync(user);
        }
        
        public System.Threading.Tasks.Task<string> GetUserDtoNameAsync(ServiceReference2.UserDto user)
        {
            return base.Channel.GetUserDtoNameAsync(user);
        }
        
        public System.Threading.Tasks.Task SetNormalizedUserNameAsync(ServiceReference2.UserDto user, string normalizedName)
        {
            return base.Channel.SetNormalizedUserNameAsync(user, normalizedName);
        }
        
        public System.Threading.Tasks.Task SeUserDtoNameAsync(ServiceReference2.UserDto user, string userName)
        {
            return base.Channel.SeUserDtoNameAsync(user, userName);
        }
        
        public System.Threading.Tasks.Task<ServiceReference2.IdentityResult> UpdateUserAsync(ServiceReference2.UserDto user)
        {
            return base.Channel.UpdateUserAsync(user);
        }
        
        public System.Threading.Tasks.Task<ServiceReference2.IdentityResult> CreateRoleAsync(ServiceReference2.IdentityRoleDto role)
        {
            return base.Channel.CreateRoleAsync(role);
        }
        
        public System.Threading.Tasks.Task<ServiceReference2.IdentityResult> DeleteRoleAsync(ServiceReference2.IdentityRoleDto role)
        {
            return base.Channel.DeleteRoleAsync(role);
        }
        
        public System.Threading.Tasks.Task<ServiceReference2.IdentityRoleDto> FindRoleByIdAsync(int roleId)
        {
            return base.Channel.FindRoleByIdAsync(roleId);
        }
        
        public System.Threading.Tasks.Task<ServiceReference2.IdentityRoleDto> FindRoleByNameAsync(string normalizedRoleName)
        {
            return base.Channel.FindRoleByNameAsync(normalizedRoleName);
        }
        
        public System.Threading.Tasks.Task<string> GetNormalizedRoleNameAsync(ServiceReference2.IdentityRoleDto role)
        {
            return base.Channel.GetNormalizedRoleNameAsync(role);
        }
        
        public System.Threading.Tasks.Task<int> GetIdentityRoleDtoIdAsync(ServiceReference2.IdentityRoleDto role)
        {
            return base.Channel.GetIdentityRoleDtoIdAsync(role);
        }
        
        public System.Threading.Tasks.Task<string> GetIdentityRoleDtoNameAsync(ServiceReference2.IdentityRoleDto role)
        {
            return base.Channel.GetIdentityRoleDtoNameAsync(role);
        }
        
        public System.Threading.Tasks.Task SetNormalizedRoleNameAsync(ServiceReference2.IdentityRoleDto role, string normalizedName)
        {
            return base.Channel.SetNormalizedRoleNameAsync(role, normalizedName);
        }
        
        public System.Threading.Tasks.Task SeIdentityRoleDtoNameAsync(ServiceReference2.IdentityRoleDto role, string roleName)
        {
            return base.Channel.SeIdentityRoleDtoNameAsync(role, roleName);
        }
        
        public System.Threading.Tasks.Task<ServiceReference2.IdentityResult> UpdateRoleAsync(ServiceReference2.IdentityRoleDto role)
        {
            return base.Channel.UpdateRoleAsync(role);
        }
        
        public System.Threading.Tasks.Task<string> GetPasswordHashAsync(ServiceReference2.UserDto userDto)
        {
            return base.Channel.GetPasswordHashAsync(userDto);
        }
        
        public System.Threading.Tasks.Task<bool> HasPasswordAsync(ServiceReference2.UserDto userDto)
        {
            return base.Channel.HasPasswordAsync(userDto);
        }
        
        public System.Threading.Tasks.Task SetPasswordHashAsync(ServiceReference2.UserDto userDto, string passwordHash)
        {
            return base.Channel.SetPasswordHashAsync(userDto, passwordHash);
        }
        
        public System.Threading.Tasks.Task<ServiceReference2.UserDto> FindByEmailAsync(string normalizedEmail)
        {
            return base.Channel.FindByEmailAsync(normalizedEmail);
        }
        
        public System.Threading.Tasks.Task<string> GetEmailAsync(ServiceReference2.UserDto user)
        {
            return base.Channel.GetEmailAsync(user);
        }
        
        public System.Threading.Tasks.Task<bool> GetEmailConfirmedAsync(ServiceReference2.UserDto user)
        {
            return base.Channel.GetEmailConfirmedAsync(user);
        }
        
        public System.Threading.Tasks.Task<string> GetNormalizedEmailAsync(ServiceReference2.UserDto user)
        {
            return base.Channel.GetNormalizedEmailAsync(user);
        }
        
        public System.Threading.Tasks.Task SetEmailAsync(ServiceReference2.UserDto user, string email)
        {
            return base.Channel.SetEmailAsync(user, email);
        }
        
        public System.Threading.Tasks.Task SetEmailConfirmedAsync(ServiceReference2.UserDto user, bool confirmed)
        {
            return base.Channel.SetEmailConfirmedAsync(user, confirmed);
        }
        
        public System.Threading.Tasks.Task SetNormalizedEmailAsync(ServiceReference2.UserDto user, string normalizedEmail)
        {
            return base.Channel.SetNormalizedEmailAsync(user, normalizedEmail);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_AuthSrv))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_AuthSrv))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:52499/AuthenticationService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return AuthSrvClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_AuthSrv);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return AuthSrvClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_AuthSrv);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_AuthSrv,
        }
    }
}