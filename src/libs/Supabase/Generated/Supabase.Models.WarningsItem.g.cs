#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct WarningsItem : global::System.IEquatable<WarningsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseWarningDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant1? PgGraphqlIntrospectionChange { get; init; }
#else
        public global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant1? PgGraphqlIntrospectionChange { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PgGraphqlIntrospectionChange))]
#endif
        public bool IsPgGraphqlIntrospectionChange => PgGraphqlIntrospectionChange != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPgGraphqlIntrospectionChange(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant1? value)
        {
            value = PgGraphqlIntrospectionChange;
            return IsPgGraphqlIntrospectionChange;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant1 PickPgGraphqlIntrospectionChange() => IsPgGraphqlIntrospectionChange
            ? PgGraphqlIntrospectionChange!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PgGraphqlIntrospectionChange' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WarningsItem(global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant1 value) => new WarningsItem((global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant1?(WarningsItem @this) => @this.PgGraphqlIntrospectionChange;

        /// <summary>
        /// 
        /// </summary>
        public WarningsItem(global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant1? value)
        {
            PgGraphqlIntrospectionChange = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WarningsItem FromPgGraphqlIntrospectionChange(global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant1? value) => new WarningsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public WarningsItem(
            global::Supabase.ProjectUpgradeEligibilityResponseWarningDiscriminatorType? type,
            global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant1? pgGraphqlIntrospectionChange
            )
        {
            Type = type;

            PgGraphqlIntrospectionChange = pgGraphqlIntrospectionChange;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PgGraphqlIntrospectionChange as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PgGraphqlIntrospectionChange?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPgGraphqlIntrospectionChange;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant1, TResult>? pgGraphqlIntrospectionChange = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPgGraphqlIntrospectionChange && pgGraphqlIntrospectionChange != null)
            {
                return pgGraphqlIntrospectionChange(PgGraphqlIntrospectionChange!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant1>? pgGraphqlIntrospectionChange = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPgGraphqlIntrospectionChange)
            {
                pgGraphqlIntrospectionChange?.Invoke(PgGraphqlIntrospectionChange!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant1>? pgGraphqlIntrospectionChange = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPgGraphqlIntrospectionChange)
            {
                pgGraphqlIntrospectionChange?.Invoke(PgGraphqlIntrospectionChange!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PgGraphqlIntrospectionChange,
                typeof(global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant1),
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
        public bool Equals(WarningsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant1?>.Default.Equals(PgGraphqlIntrospectionChange, other.PgGraphqlIntrospectionChange) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WarningsItem obj1, WarningsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WarningsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WarningsItem obj1, WarningsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WarningsItem o && Equals(o);
        }
    }
}
