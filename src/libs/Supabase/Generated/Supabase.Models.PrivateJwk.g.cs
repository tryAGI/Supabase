#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PrivateJwk : global::System.IEquatable<PrivateJwk>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Supabase.CreateSigningKeyBodyPrivateJwkDiscriminatorKty? Kty { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1? Rsa { get; init; }
#else
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1? Rsa { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Rsa))]
#endif
        public bool IsRsa => Rsa != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRsa(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1? value)
        {
            value = Rsa;
            return IsRsa;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2? Ec { get; init; }
#else
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2? Ec { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Ec))]
#endif
        public bool IsEc => Ec != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEc(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2? value)
        {
            value = Ec;
            return IsEc;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3? Okp { get; init; }
#else
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3? Okp { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Okp))]
#endif
        public bool IsOkp => Okp != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOkp(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3? value)
        {
            value = Okp;
            return IsOkp;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4? Oct { get; init; }
#else
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4? Oct { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Oct))]
#endif
        public bool IsOct => Oct != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOct(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4? value)
        {
            value = Oct;
            return IsOct;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PrivateJwk(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1 value) => new PrivateJwk((global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1?(PrivateJwk @this) => @this.Rsa;

        /// <summary>
        /// 
        /// </summary>
        public PrivateJwk(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1? value)
        {
            Rsa = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PrivateJwk(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2 value) => new PrivateJwk((global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2?(PrivateJwk @this) => @this.Ec;

        /// <summary>
        /// 
        /// </summary>
        public PrivateJwk(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2? value)
        {
            Ec = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PrivateJwk(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3 value) => new PrivateJwk((global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3?(PrivateJwk @this) => @this.Okp;

        /// <summary>
        /// 
        /// </summary>
        public PrivateJwk(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3? value)
        {
            Okp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PrivateJwk(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4 value) => new PrivateJwk((global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4?(PrivateJwk @this) => @this.Oct;

        /// <summary>
        /// 
        /// </summary>
        public PrivateJwk(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4? value)
        {
            Oct = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PrivateJwk(
            global::Supabase.CreateSigningKeyBodyPrivateJwkDiscriminatorKty? kty,
            global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1? rsa,
            global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2? ec,
            global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3? okp,
            global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4? oct
            )
        {
            Kty = kty;

            Rsa = rsa;
            Ec = ec;
            Okp = okp;
            Oct = oct;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Oct as object ??
            Okp as object ??
            Ec as object ??
            Rsa as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Rsa?.ToString() ??
            Ec?.ToString() ??
            Okp?.ToString() ??
            Oct?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRsa && !IsEc && !IsOkp && !IsOct || !IsRsa && IsEc && !IsOkp && !IsOct || !IsRsa && !IsEc && IsOkp && !IsOct || !IsRsa && !IsEc && !IsOkp && IsOct;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1, TResult>? rsa = null,
            global::System.Func<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2, TResult>? ec = null,
            global::System.Func<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3, TResult>? okp = null,
            global::System.Func<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4, TResult>? oct = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRsa && rsa != null)
            {
                return rsa(Rsa!);
            }
            else if (IsEc && ec != null)
            {
                return ec(Ec!);
            }
            else if (IsOkp && okp != null)
            {
                return okp(Okp!);
            }
            else if (IsOct && oct != null)
            {
                return oct(Oct!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1>? rsa = null,

            global::System.Action<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2>? ec = null,

            global::System.Action<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3>? okp = null,

            global::System.Action<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4>? oct = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRsa)
            {
                rsa?.Invoke(Rsa!);
            }
            else if (IsEc)
            {
                ec?.Invoke(Ec!);
            }
            else if (IsOkp)
            {
                okp?.Invoke(Okp!);
            }
            else if (IsOct)
            {
                oct?.Invoke(Oct!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1>? rsa = null,
            global::System.Action<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2>? ec = null,
            global::System.Action<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3>? okp = null,
            global::System.Action<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4>? oct = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRsa)
            {
                rsa?.Invoke(Rsa!);
            }
            else if (IsEc)
            {
                ec?.Invoke(Ec!);
            }
            else if (IsOkp)
            {
                okp?.Invoke(Okp!);
            }
            else if (IsOct)
            {
                oct?.Invoke(Oct!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Rsa,
                typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1),
                Ec,
                typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2),
                Okp,
                typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3),
                Oct,
                typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(PrivateJwk other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1?>.Default.Equals(Rsa, other.Rsa) &&
                global::System.Collections.Generic.EqualityComparer<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2?>.Default.Equals(Ec, other.Ec) &&
                global::System.Collections.Generic.EqualityComparer<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3?>.Default.Equals(Okp, other.Okp) &&
                global::System.Collections.Generic.EqualityComparer<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4?>.Default.Equals(Oct, other.Oct) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PrivateJwk obj1, PrivateJwk obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PrivateJwk>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PrivateJwk obj1, PrivateJwk obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PrivateJwk o && Equals(o);
        }
    }
}
