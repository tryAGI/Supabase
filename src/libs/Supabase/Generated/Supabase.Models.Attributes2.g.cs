#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Attributes2 : global::System.IEquatable<Attributes2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Supabase.DiskRequestBodyAttributesDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Supabase.DiskRequestBodyAttributesVariant1? Gp3 { get; init; }
#else
        public global::Supabase.DiskRequestBodyAttributesVariant1? Gp3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Gp3))]
#endif
        public bool IsGp3 => Gp3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGp3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Supabase.DiskRequestBodyAttributesVariant1? value)
        {
            value = Gp3;
            return IsGp3;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Supabase.DiskRequestBodyAttributesVariant2? Io2 { get; init; }
#else
        public global::Supabase.DiskRequestBodyAttributesVariant2? Io2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Io2))]
#endif
        public bool IsIo2 => Io2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickIo2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Supabase.DiskRequestBodyAttributesVariant2? value)
        {
            value = Io2;
            return IsIo2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Attributes2(global::Supabase.DiskRequestBodyAttributesVariant1 value) => new Attributes2((global::Supabase.DiskRequestBodyAttributesVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Supabase.DiskRequestBodyAttributesVariant1?(Attributes2 @this) => @this.Gp3;

        /// <summary>
        /// 
        /// </summary>
        public Attributes2(global::Supabase.DiskRequestBodyAttributesVariant1? value)
        {
            Gp3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Attributes2(global::Supabase.DiskRequestBodyAttributesVariant2 value) => new Attributes2((global::Supabase.DiskRequestBodyAttributesVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Supabase.DiskRequestBodyAttributesVariant2?(Attributes2 @this) => @this.Io2;

        /// <summary>
        /// 
        /// </summary>
        public Attributes2(global::Supabase.DiskRequestBodyAttributesVariant2? value)
        {
            Io2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Attributes2(
            global::Supabase.DiskRequestBodyAttributesDiscriminatorType? type,
            global::Supabase.DiskRequestBodyAttributesVariant1? gp3,
            global::Supabase.DiskRequestBodyAttributesVariant2? io2
            )
        {
            Type = type;

            Gp3 = gp3;
            Io2 = io2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Io2 as object ??
            Gp3 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Gp3?.ToString() ??
            Io2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGp3 && !IsIo2 || !IsGp3 && IsIo2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Supabase.DiskRequestBodyAttributesVariant1, TResult>? gp3 = null,
            global::System.Func<global::Supabase.DiskRequestBodyAttributesVariant2, TResult>? io2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGp3 && gp3 != null)
            {
                return gp3(Gp3!);
            }
            else if (IsIo2 && io2 != null)
            {
                return io2(Io2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Supabase.DiskRequestBodyAttributesVariant1>? gp3 = null,

            global::System.Action<global::Supabase.DiskRequestBodyAttributesVariant2>? io2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGp3)
            {
                gp3?.Invoke(Gp3!);
            }
            else if (IsIo2)
            {
                io2?.Invoke(Io2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Supabase.DiskRequestBodyAttributesVariant1>? gp3 = null,
            global::System.Action<global::Supabase.DiskRequestBodyAttributesVariant2>? io2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGp3)
            {
                gp3?.Invoke(Gp3!);
            }
            else if (IsIo2)
            {
                io2?.Invoke(Io2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Gp3,
                typeof(global::Supabase.DiskRequestBodyAttributesVariant1),
                Io2,
                typeof(global::Supabase.DiskRequestBodyAttributesVariant2),
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
        public bool Equals(Attributes2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Supabase.DiskRequestBodyAttributesVariant1?>.Default.Equals(Gp3, other.Gp3) &&
                global::System.Collections.Generic.EqualityComparer<global::Supabase.DiskRequestBodyAttributesVariant2?>.Default.Equals(Io2, other.Io2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Attributes2 obj1, Attributes2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Attributes2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Attributes2 obj1, Attributes2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Attributes2 o && Equals(o);
        }
    }
}
