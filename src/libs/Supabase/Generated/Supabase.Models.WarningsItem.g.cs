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
#if NET6_0_OR_GREATER
        public global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant2? LtreeReindexRequired { get; init; }
#else
        public global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant2? LtreeReindexRequired { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LtreeReindexRequired))]
#endif
        public bool IsLtreeReindexRequired => LtreeReindexRequired != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLtreeReindexRequired(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant2? value)
        {
            value = LtreeReindexRequired;
            return IsLtreeReindexRequired;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant2 PickLtreeReindexRequired() => IsLtreeReindexRequired
            ? LtreeReindexRequired!
            : throw new global::System.InvalidOperationException($"Expected union variant 'LtreeReindexRequired' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant3? OperatorEstimatorGate { get; init; }
#else
        public global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant3? OperatorEstimatorGate { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OperatorEstimatorGate))]
#endif
        public bool IsOperatorEstimatorGate => OperatorEstimatorGate != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOperatorEstimatorGate(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant3? value)
        {
            value = OperatorEstimatorGate;
            return IsOperatorEstimatorGate;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant3 PickOperatorEstimatorGate() => IsOperatorEstimatorGate
            ? OperatorEstimatorGate!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OperatorEstimatorGate' but the value was {ToString()}.");
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
        public static implicit operator WarningsItem(global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant2 value) => new WarningsItem((global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant2?(WarningsItem @this) => @this.LtreeReindexRequired;

        /// <summary>
        /// 
        /// </summary>
        public WarningsItem(global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant2? value)
        {
            LtreeReindexRequired = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WarningsItem FromLtreeReindexRequired(global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant2? value) => new WarningsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WarningsItem(global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant3 value) => new WarningsItem((global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant3?(WarningsItem @this) => @this.OperatorEstimatorGate;

        /// <summary>
        /// 
        /// </summary>
        public WarningsItem(global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant3? value)
        {
            OperatorEstimatorGate = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WarningsItem FromOperatorEstimatorGate(global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant3? value) => new WarningsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public WarningsItem(
            global::Supabase.ProjectUpgradeEligibilityResponseWarningDiscriminatorType? type,
            global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant1? pgGraphqlIntrospectionChange,
            global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant2? ltreeReindexRequired,
            global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant3? operatorEstimatorGate
            )
        {
            Type = type;

            PgGraphqlIntrospectionChange = pgGraphqlIntrospectionChange;
            LtreeReindexRequired = ltreeReindexRequired;
            OperatorEstimatorGate = operatorEstimatorGate;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OperatorEstimatorGate as object ??
            LtreeReindexRequired as object ??
            PgGraphqlIntrospectionChange as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PgGraphqlIntrospectionChange?.ToString() ??
            LtreeReindexRequired?.ToString() ??
            OperatorEstimatorGate?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPgGraphqlIntrospectionChange && !IsLtreeReindexRequired && !IsOperatorEstimatorGate || !IsPgGraphqlIntrospectionChange && IsLtreeReindexRequired && !IsOperatorEstimatorGate || !IsPgGraphqlIntrospectionChange && !IsLtreeReindexRequired && IsOperatorEstimatorGate;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant1, TResult>? pgGraphqlIntrospectionChange = null,
            global::System.Func<global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant2, TResult>? ltreeReindexRequired = null,
            global::System.Func<global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant3, TResult>? operatorEstimatorGate = null,
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
            else if (IsLtreeReindexRequired && ltreeReindexRequired != null)
            {
                return ltreeReindexRequired(LtreeReindexRequired!);
            }
            else if (IsOperatorEstimatorGate && operatorEstimatorGate != null)
            {
                return operatorEstimatorGate(OperatorEstimatorGate!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant1>? pgGraphqlIntrospectionChange = null,

            global::System.Action<global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant2>? ltreeReindexRequired = null,

            global::System.Action<global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant3>? operatorEstimatorGate = null,
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
            else if (IsLtreeReindexRequired)
            {
                ltreeReindexRequired?.Invoke(LtreeReindexRequired!);
            }
            else if (IsOperatorEstimatorGate)
            {
                operatorEstimatorGate?.Invoke(OperatorEstimatorGate!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant1>? pgGraphqlIntrospectionChange = null,
            global::System.Action<global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant2>? ltreeReindexRequired = null,
            global::System.Action<global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant3>? operatorEstimatorGate = null,
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
            else if (IsLtreeReindexRequired)
            {
                ltreeReindexRequired?.Invoke(LtreeReindexRequired!);
            }
            else if (IsOperatorEstimatorGate)
            {
                operatorEstimatorGate?.Invoke(OperatorEstimatorGate!);
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
                LtreeReindexRequired,
                typeof(global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant2),
                OperatorEstimatorGate,
                typeof(global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant3),
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
                global::System.Collections.Generic.EqualityComparer<global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant1?>.Default.Equals(PgGraphqlIntrospectionChange, other.PgGraphqlIntrospectionChange) &&
                global::System.Collections.Generic.EqualityComparer<global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant2?>.Default.Equals(LtreeReindexRequired, other.LtreeReindexRequired) &&
                global::System.Collections.Generic.EqualityComparer<global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant3?>.Default.Equals(OperatorEstimatorGate, other.OperatorEstimatorGate) 
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
