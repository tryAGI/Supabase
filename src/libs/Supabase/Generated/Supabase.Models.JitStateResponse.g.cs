#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct JitStateResponse : global::System.IEquatable<JitStateResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Supabase.JitStateResponseVariant1? JitStateResponseVariant1 { get; init; }
#else
        public global::Supabase.JitStateResponseVariant1? JitStateResponseVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JitStateResponseVariant1))]
#endif
        public bool IsJitStateResponseVariant1 => JitStateResponseVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Supabase.JitStateResponseVariant2? Unavailable { get; init; }
#else
        public global::Supabase.JitStateResponseVariant2? Unavailable { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Unavailable))]
#endif
        public bool IsUnavailable => Unavailable != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JitStateResponse(global::Supabase.JitStateResponseVariant1 value) => new JitStateResponse((global::Supabase.JitStateResponseVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Supabase.JitStateResponseVariant1?(JitStateResponse @this) => @this.JitStateResponseVariant1;

        /// <summary>
        /// 
        /// </summary>
        public JitStateResponse(global::Supabase.JitStateResponseVariant1? value)
        {
            JitStateResponseVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JitStateResponse(global::Supabase.JitStateResponseVariant2 value) => new JitStateResponse((global::Supabase.JitStateResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Supabase.JitStateResponseVariant2?(JitStateResponse @this) => @this.Unavailable;

        /// <summary>
        /// 
        /// </summary>
        public JitStateResponse(global::Supabase.JitStateResponseVariant2? value)
        {
            Unavailable = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public JitStateResponse(
            global::Supabase.JitStateResponseVariant1? jitStateResponseVariant1,
            global::Supabase.JitStateResponseVariant2? unavailable
            )
        {
            JitStateResponseVariant1 = jitStateResponseVariant1;
            Unavailable = unavailable;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Unavailable as object ??
            JitStateResponseVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            JitStateResponseVariant1?.ToString() ??
            Unavailable?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsJitStateResponseVariant1 && !IsUnavailable || !IsJitStateResponseVariant1 && IsUnavailable;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Supabase.JitStateResponseVariant1?, TResult>? jitStateResponseVariant1 = null,
            global::System.Func<global::Supabase.JitStateResponseVariant2?, TResult>? unavailable = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJitStateResponseVariant1 && jitStateResponseVariant1 != null)
            {
                return jitStateResponseVariant1(JitStateResponseVariant1!);
            }
            else if (IsUnavailable && unavailable != null)
            {
                return unavailable(Unavailable!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Supabase.JitStateResponseVariant1?>? jitStateResponseVariant1 = null,
            global::System.Action<global::Supabase.JitStateResponseVariant2?>? unavailable = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJitStateResponseVariant1)
            {
                jitStateResponseVariant1?.Invoke(JitStateResponseVariant1!);
            }
            else if (IsUnavailable)
            {
                unavailable?.Invoke(Unavailable!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                JitStateResponseVariant1,
                typeof(global::Supabase.JitStateResponseVariant1),
                Unavailable,
                typeof(global::Supabase.JitStateResponseVariant2),
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
        public bool Equals(JitStateResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Supabase.JitStateResponseVariant1?>.Default.Equals(JitStateResponseVariant1, other.JitStateResponseVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Supabase.JitStateResponseVariant2?>.Default.Equals(Unavailable, other.Unavailable) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(JitStateResponse obj1, JitStateResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<JitStateResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(JitStateResponse obj1, JitStateResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is JitStateResponse o && Equals(o);
        }
    }
}
