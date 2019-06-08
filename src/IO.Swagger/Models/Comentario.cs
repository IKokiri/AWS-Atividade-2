/*
 * Livraria Virtual
 *
 * Manipulação de livros e suas dependências 
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Comentario : IEquatable<Comentario>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Nome
        /// </summary>
        [DataMember(Name="nome")]
        public string Nome { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data")]
        public DateTime? Data { get; set; }

        /// <summary>
        /// Gets or Sets _Comentario
        /// </summary>
        [DataMember(Name="comentario")]
        public string _Comentario { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Comentario {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  _Comentario: ").Append(_Comentario).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Comentario)obj);
        }

        /// <summary>
        /// Returns true if Comentario instances are equal
        /// </summary>
        /// <param name="other">Instance of Comentario to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Comentario other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Nome == other.Nome ||
                    Nome != null &&
                    Nome.Equals(other.Nome)
                ) && 
                (
                    Data == other.Data ||
                    Data != null &&
                    Data.Equals(other.Data)
                ) && 
                (
                    _Comentario == other._Comentario ||
                    _Comentario != null &&
                    _Comentario.Equals(other._Comentario)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Nome != null)
                    hashCode = hashCode * 59 + Nome.GetHashCode();
                    if (Data != null)
                    hashCode = hashCode * 59 + Data.GetHashCode();
                    if (_Comentario != null)
                    hashCode = hashCode * 59 + _Comentario.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Comentario left, Comentario right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Comentario left, Comentario right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}