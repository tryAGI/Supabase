#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Supabase
{
    /// <summary>
    /// Region selection. Only one of region or region_selection can be specified.
    /// </summary>
    public readonly partial struct RegionSelection : global::System.IEquatable<RegionSelection>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Supabase.V1CreateProjectBodyRegionSelectionDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Supabase.V1CreateProjectBodyRegionSelectionVariant1? Specific { get; init; }
#else
        public global::Supabase.V1CreateProjectBodyRegionSelectionVariant1? Specific { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Specific))]
#endif
        public bool IsSpecific => Specific != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSpecific(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Supabase.V1CreateProjectBodyRegionSelectionVariant1? value)
        {
            value = Specific;
            return IsSpecific;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Supabase.V1CreateProjectBodyRegionSelectionVariant2? SmartGroup { get; init; }
#else
        public global::Supabase.V1CreateProjectBodyRegionSelectionVariant2? SmartGroup { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SmartGroup))]
#endif
        public bool IsSmartGroup => SmartGroup != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSmartGroup(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Supabase.V1CreateProjectBodyRegionSelectionVariant2? value)
        {
            value = SmartGroup;
            return IsSmartGroup;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RegionSelection(global::Supabase.V1CreateProjectBodyRegionSelectionVariant1 value) => new RegionSelection((global::Supabase.V1CreateProjectBodyRegionSelectionVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Supabase.V1CreateProjectBodyRegionSelectionVariant1?(RegionSelection @this) => @this.Specific;

        /// <summary>
        /// 
        /// </summary>
        public RegionSelection(global::Supabase.V1CreateProjectBodyRegionSelectionVariant1? value)
        {
            Specific = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RegionSelection(global::Supabase.V1CreateProjectBodyRegionSelectionVariant2 value) => new RegionSelection((global::Supabase.V1CreateProjectBodyRegionSelectionVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Supabase.V1CreateProjectBodyRegionSelectionVariant2?(RegionSelection @this) => @this.SmartGroup;

        /// <summary>
        /// 
        /// </summary>
        public RegionSelection(global::Supabase.V1CreateProjectBodyRegionSelectionVariant2? value)
        {
            SmartGroup = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RegionSelection(
            global::Supabase.V1CreateProjectBodyRegionSelectionDiscriminatorType? type,
            global::Supabase.V1CreateProjectBodyRegionSelectionVariant1? specific,
            global::Supabase.V1CreateProjectBodyRegionSelectionVariant2? smartGroup
            )
        {
            Type = type;

            Specific = specific;
            SmartGroup = smartGroup;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SmartGroup as object ??
            Specific as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Specific?.ToString() ??
            SmartGroup?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSpecific && !IsSmartGroup || !IsSpecific && IsSmartGroup;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Supabase.V1CreateProjectBodyRegionSelectionVariant1, TResult>? specific = null,
            global::System.Func<global::Supabase.V1CreateProjectBodyRegionSelectionVariant2, TResult>? smartGroup = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSpecific && specific != null)
            {
                return specific(Specific!);
            }
            else if (IsSmartGroup && smartGroup != null)
            {
                return smartGroup(SmartGroup!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Supabase.V1CreateProjectBodyRegionSelectionVariant1>? specific = null,

            global::System.Action<global::Supabase.V1CreateProjectBodyRegionSelectionVariant2>? smartGroup = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSpecific)
            {
                specific?.Invoke(Specific!);
            }
            else if (IsSmartGroup)
            {
                smartGroup?.Invoke(SmartGroup!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Supabase.V1CreateProjectBodyRegionSelectionVariant1>? specific = null,
            global::System.Action<global::Supabase.V1CreateProjectBodyRegionSelectionVariant2>? smartGroup = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSpecific)
            {
                specific?.Invoke(Specific!);
            }
            else if (IsSmartGroup)
            {
                smartGroup?.Invoke(SmartGroup!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Specific,
                typeof(global::Supabase.V1CreateProjectBodyRegionSelectionVariant1),
                SmartGroup,
                typeof(global::Supabase.V1CreateProjectBodyRegionSelectionVariant2),
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
        public bool Equals(RegionSelection other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Supabase.V1CreateProjectBodyRegionSelectionVariant1?>.Default.Equals(Specific, other.Specific) &&
                global::System.Collections.Generic.EqualityComparer<global::Supabase.V1CreateProjectBodyRegionSelectionVariant2?>.Default.Equals(SmartGroup, other.SmartGroup) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RegionSelection obj1, RegionSelection obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RegionSelection>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RegionSelection obj1, RegionSelection obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RegionSelection o && Equals(o);
        }
    }
}
