/* 
 * Vacancy API
 *
 * Web API for AstralVacancy task project.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Модель обновления данных пользователя
    /// </summary>
    [DataContract]
    public partial class UserUpdateDto :  IEquatable<UserUpdateDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserUpdateDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserUpdateDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserUpdateDto" /> class.
        /// </summary>
        /// <param name="Id">Идентификатор пользователя (required).</param>
        /// <param name="Login">Login пользователя (required).</param>
        /// <param name="IsAdmin">Флаг админа (required).</param>
        /// <param name="FullName">Полное имя (required).</param>
        public UserUpdateDto(int? Id = default(int?), string Login = default(string), bool? IsAdmin = default(bool?), string FullName = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for UserUpdateDto and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Login" is required (not null)
            if (Login == null)
            {
                throw new InvalidDataException("Login is a required property for UserUpdateDto and cannot be null");
            }
            else
            {
                this.Login = Login;
            }
            // to ensure "IsAdmin" is required (not null)
            if (IsAdmin == null)
            {
                throw new InvalidDataException("IsAdmin is a required property for UserUpdateDto and cannot be null");
            }
            else
            {
                this.IsAdmin = IsAdmin;
            }
            // to ensure "FullName" is required (not null)
            if (FullName == null)
            {
                throw new InvalidDataException("FullName is a required property for UserUpdateDto and cannot be null");
            }
            else
            {
                this.FullName = FullName;
            }
        }
        
        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        /// <value>Идентификатор пользователя</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Login пользователя
        /// </summary>
        /// <value>Login пользователя</value>
        [DataMember(Name="login", EmitDefaultValue=false)]
        public string Login { get; set; }

        /// <summary>
        /// Флаг админа
        /// </summary>
        /// <value>Флаг админа</value>
        [DataMember(Name="isAdmin", EmitDefaultValue=false)]
        public bool? IsAdmin { get; set; }

        /// <summary>
        /// Полное имя
        /// </summary>
        /// <value>Полное имя</value>
        [DataMember(Name="fullName", EmitDefaultValue=false)]
        public string FullName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserUpdateDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
            sb.Append("  IsAdmin: ").Append(IsAdmin).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserUpdateDto);
        }

        /// <summary>
        /// Returns true if UserUpdateDto instances are equal
        /// </summary>
        /// <param name="input">Instance of UserUpdateDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserUpdateDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Login == input.Login ||
                    (this.Login != null &&
                    this.Login.Equals(input.Login))
                ) && 
                (
                    this.IsAdmin == input.IsAdmin ||
                    (this.IsAdmin != null &&
                    this.IsAdmin.Equals(input.IsAdmin))
                ) && 
                (
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Login != null)
                    hashCode = hashCode * 59 + this.Login.GetHashCode();
                if (this.IsAdmin != null)
                    hashCode = hashCode * 59 + this.IsAdmin.GetHashCode();
                if (this.FullName != null)
                    hashCode = hashCode * 59 + this.FullName.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
