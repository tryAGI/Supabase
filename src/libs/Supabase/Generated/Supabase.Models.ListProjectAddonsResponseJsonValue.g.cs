#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Supabase
{
    /// <summary>
    /// Any JSON-serializable value
    /// </summary>
    public readonly partial struct ListProjectAddonsResponseJsonValue : global::System.IEquatable<ListProjectAddonsResponseJsonValue>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Supabase.AnyOf<string, double?, bool?>? ListProjectAddonsResponseJsonValueVariant1 { get; init; }
#else
        public global::Supabase.AnyOf<string, double?, bool?>? ListProjectAddonsResponseJsonValueVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListProjectAddonsResponseJsonValueVariant1))]
#endif
        public bool IsListProjectAddonsResponseJsonValueVariant1 => ListProjectAddonsResponseJsonValueVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickListProjectAddonsResponseJsonValueVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Supabase.AnyOf<string, double?, bool?>? value)
        {
            value = ListProjectAddonsResponseJsonValueVariant1;
            return IsListProjectAddonsResponseJsonValueVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Supabase.AnyOf<string, double?, bool?> PickListProjectAddonsResponseJsonValueVariant1() => IsListProjectAddonsResponseJsonValueVariant1
            ? ListProjectAddonsResponseJsonValueVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ListProjectAddonsResponseJsonValueVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Supabase.ListProjectAddonsResponseJsonValue>? ListProjectAddonsResponseJsonValueVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Supabase.ListProjectAddonsResponseJsonValue>? ListProjectAddonsResponseJsonValueVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListProjectAddonsResponseJsonValueVariant2))]
#endif
        public bool IsListProjectAddonsResponseJsonValueVariant2 => ListProjectAddonsResponseJsonValueVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickListProjectAddonsResponseJsonValueVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Supabase.ListProjectAddonsResponseJsonValue>? value)
        {
            value = ListProjectAddonsResponseJsonValueVariant2;
            return IsListProjectAddonsResponseJsonValueVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.ListProjectAddonsResponseJsonValue> PickListProjectAddonsResponseJsonValueVariant2() => IsListProjectAddonsResponseJsonValueVariant2
            ? ListProjectAddonsResponseJsonValueVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ListProjectAddonsResponseJsonValueVariant2' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? ListProjectAddonsResponseJsonValueVariant3 { get; init; }
#else
        public object? ListProjectAddonsResponseJsonValueVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListProjectAddonsResponseJsonValueVariant3))]
#endif
        public bool IsListProjectAddonsResponseJsonValueVariant3 => ListProjectAddonsResponseJsonValueVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickListProjectAddonsResponseJsonValueVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = ListProjectAddonsResponseJsonValueVariant3;
            return IsListProjectAddonsResponseJsonValueVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object PickListProjectAddonsResponseJsonValueVariant3() => IsListProjectAddonsResponseJsonValueVariant3
            ? ListProjectAddonsResponseJsonValueVariant3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ListProjectAddonsResponseJsonValueVariant3' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListProjectAddonsResponseJsonValue(global::Supabase.AnyOf<string, double?, bool?> value) => new ListProjectAddonsResponseJsonValue((global::Supabase.AnyOf<string, double?, bool?>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Supabase.AnyOf<string, double?, bool?>?(ListProjectAddonsResponseJsonValue @this) => @this.ListProjectAddonsResponseJsonValueVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ListProjectAddonsResponseJsonValue(global::Supabase.AnyOf<string, double?, bool?>? value)
        {
            ListProjectAddonsResponseJsonValueVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ListProjectAddonsResponseJsonValue FromListProjectAddonsResponseJsonValueVariant1(global::Supabase.AnyOf<string, double?, bool?>? value) => new ListProjectAddonsResponseJsonValue(value);

        /// <summary>
        /// 
        /// </summary>
        public ListProjectAddonsResponseJsonValue(
            global::Supabase.AnyOf<string, double?, bool?>? listProjectAddonsResponseJsonValueVariant1,
            global::System.Collections.Generic.IList<global::Supabase.ListProjectAddonsResponseJsonValue>? listProjectAddonsResponseJsonValueVariant2,
            object? listProjectAddonsResponseJsonValueVariant3
            )
        {
            ListProjectAddonsResponseJsonValueVariant1 = listProjectAddonsResponseJsonValueVariant1;
            ListProjectAddonsResponseJsonValueVariant2 = listProjectAddonsResponseJsonValueVariant2;
            ListProjectAddonsResponseJsonValueVariant3 = listProjectAddonsResponseJsonValueVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ListProjectAddonsResponseJsonValueVariant3 as object ??
            ListProjectAddonsResponseJsonValueVariant2 as object ??
            ListProjectAddonsResponseJsonValueVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ListProjectAddonsResponseJsonValueVariant1?.ToString() ??
            ListProjectAddonsResponseJsonValueVariant2?.ToString() ??
            ListProjectAddonsResponseJsonValueVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsListProjectAddonsResponseJsonValueVariant1 || IsListProjectAddonsResponseJsonValueVariant2 || IsListProjectAddonsResponseJsonValueVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Supabase.AnyOf<string, double?, bool?>?, TResult>? listProjectAddonsResponseJsonValueVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Supabase.ListProjectAddonsResponseJsonValue>, TResult>? listProjectAddonsResponseJsonValueVariant2 = null,
            global::System.Func<object, TResult>? listProjectAddonsResponseJsonValueVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsListProjectAddonsResponseJsonValueVariant1 && listProjectAddonsResponseJsonValueVariant1 != null)
            {
                return listProjectAddonsResponseJsonValueVariant1(ListProjectAddonsResponseJsonValueVariant1!);
            }
            else if (IsListProjectAddonsResponseJsonValueVariant2 && listProjectAddonsResponseJsonValueVariant2 != null)
            {
                return listProjectAddonsResponseJsonValueVariant2(ListProjectAddonsResponseJsonValueVariant2!);
            }
            else if (IsListProjectAddonsResponseJsonValueVariant3 && listProjectAddonsResponseJsonValueVariant3 != null)
            {
                return listProjectAddonsResponseJsonValueVariant3(ListProjectAddonsResponseJsonValueVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Supabase.AnyOf<string, double?, bool?>?>? listProjectAddonsResponseJsonValueVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::Supabase.ListProjectAddonsResponseJsonValue>>? listProjectAddonsResponseJsonValueVariant2 = null,

            global::System.Action<object>? listProjectAddonsResponseJsonValueVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsListProjectAddonsResponseJsonValueVariant1)
            {
                listProjectAddonsResponseJsonValueVariant1?.Invoke(ListProjectAddonsResponseJsonValueVariant1!);
            }
            else if (IsListProjectAddonsResponseJsonValueVariant2)
            {
                listProjectAddonsResponseJsonValueVariant2?.Invoke(ListProjectAddonsResponseJsonValueVariant2!);
            }
            else if (IsListProjectAddonsResponseJsonValueVariant3)
            {
                listProjectAddonsResponseJsonValueVariant3?.Invoke(ListProjectAddonsResponseJsonValueVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Supabase.AnyOf<string, double?, bool?>?>? listProjectAddonsResponseJsonValueVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Supabase.ListProjectAddonsResponseJsonValue>>? listProjectAddonsResponseJsonValueVariant2 = null,
            global::System.Action<object>? listProjectAddonsResponseJsonValueVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsListProjectAddonsResponseJsonValueVariant1)
            {
                listProjectAddonsResponseJsonValueVariant1?.Invoke(ListProjectAddonsResponseJsonValueVariant1!);
            }
            else if (IsListProjectAddonsResponseJsonValueVariant2)
            {
                listProjectAddonsResponseJsonValueVariant2?.Invoke(ListProjectAddonsResponseJsonValueVariant2!);
            }
            else if (IsListProjectAddonsResponseJsonValueVariant3)
            {
                listProjectAddonsResponseJsonValueVariant3?.Invoke(ListProjectAddonsResponseJsonValueVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ListProjectAddonsResponseJsonValueVariant1,
                typeof(global::Supabase.AnyOf<string, double?, bool?>),
                ListProjectAddonsResponseJsonValueVariant2,
                typeof(global::System.Collections.Generic.IList<global::Supabase.ListProjectAddonsResponseJsonValue>),
                ListProjectAddonsResponseJsonValueVariant3,
                typeof(object),
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
        public bool Equals(ListProjectAddonsResponseJsonValue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Supabase.AnyOf<string, double?, bool?>?>.Default.Equals(ListProjectAddonsResponseJsonValueVariant1, other.ListProjectAddonsResponseJsonValueVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Supabase.ListProjectAddonsResponseJsonValue>?>.Default.Equals(ListProjectAddonsResponseJsonValueVariant2, other.ListProjectAddonsResponseJsonValueVariant2) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ListProjectAddonsResponseJsonValueVariant3, other.ListProjectAddonsResponseJsonValueVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ListProjectAddonsResponseJsonValue obj1, ListProjectAddonsResponseJsonValue obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ListProjectAddonsResponseJsonValue>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ListProjectAddonsResponseJsonValue obj1, ListProjectAddonsResponseJsonValue obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ListProjectAddonsResponseJsonValue o && Equals(o);
        }
    }
}
