#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Supabase
{
    /// <summary>
    /// Any JSON-serializable value
    /// </summary>
    public readonly partial struct UpdateCustomHostnameResponseJsonValue : global::System.IEquatable<UpdateCustomHostnameResponseJsonValue>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Supabase.AnyOf<string, double?, bool?>? UpdateCustomHostnameResponseJsonValueVariant1 { get; init; }
#else
        public global::Supabase.AnyOf<string, double?, bool?>? UpdateCustomHostnameResponseJsonValueVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateCustomHostnameResponseJsonValueVariant1))]
#endif
        public bool IsUpdateCustomHostnameResponseJsonValueVariant1 => UpdateCustomHostnameResponseJsonValueVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUpdateCustomHostnameResponseJsonValueVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Supabase.AnyOf<string, double?, bool?>? value)
        {
            value = UpdateCustomHostnameResponseJsonValueVariant1;
            return IsUpdateCustomHostnameResponseJsonValueVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Supabase.AnyOf<string, double?, bool?> PickUpdateCustomHostnameResponseJsonValueVariant1() => IsUpdateCustomHostnameResponseJsonValueVariant1
            ? UpdateCustomHostnameResponseJsonValueVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UpdateCustomHostnameResponseJsonValueVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Supabase.UpdateCustomHostnameResponseJsonValue>? UpdateCustomHostnameResponseJsonValueVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Supabase.UpdateCustomHostnameResponseJsonValue>? UpdateCustomHostnameResponseJsonValueVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateCustomHostnameResponseJsonValueVariant2))]
#endif
        public bool IsUpdateCustomHostnameResponseJsonValueVariant2 => UpdateCustomHostnameResponseJsonValueVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUpdateCustomHostnameResponseJsonValueVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Supabase.UpdateCustomHostnameResponseJsonValue>? value)
        {
            value = UpdateCustomHostnameResponseJsonValueVariant2;
            return IsUpdateCustomHostnameResponseJsonValueVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.UpdateCustomHostnameResponseJsonValue> PickUpdateCustomHostnameResponseJsonValueVariant2() => IsUpdateCustomHostnameResponseJsonValueVariant2
            ? UpdateCustomHostnameResponseJsonValueVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UpdateCustomHostnameResponseJsonValueVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? UpdateCustomHostnameResponseJsonValueVariant3 { get; init; }
#else
        public object? UpdateCustomHostnameResponseJsonValueVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateCustomHostnameResponseJsonValueVariant3))]
#endif
        public bool IsUpdateCustomHostnameResponseJsonValueVariant3 => UpdateCustomHostnameResponseJsonValueVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUpdateCustomHostnameResponseJsonValueVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = UpdateCustomHostnameResponseJsonValueVariant3;
            return IsUpdateCustomHostnameResponseJsonValueVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickUpdateCustomHostnameResponseJsonValueVariant3() => IsUpdateCustomHostnameResponseJsonValueVariant3
            ? UpdateCustomHostnameResponseJsonValueVariant3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UpdateCustomHostnameResponseJsonValueVariant3' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator UpdateCustomHostnameResponseJsonValue(global::Supabase.AnyOf<string, double?, bool?> value) => new UpdateCustomHostnameResponseJsonValue((global::Supabase.AnyOf<string, double?, bool?>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Supabase.AnyOf<string, double?, bool?>?(UpdateCustomHostnameResponseJsonValue @this) => @this.UpdateCustomHostnameResponseJsonValueVariant1;

        /// <summary>
        ///
        /// </summary>
        public UpdateCustomHostnameResponseJsonValue(global::Supabase.AnyOf<string, double?, bool?>? value)
        {
            UpdateCustomHostnameResponseJsonValueVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UpdateCustomHostnameResponseJsonValue FromUpdateCustomHostnameResponseJsonValueVariant1(global::Supabase.AnyOf<string, double?, bool?>? value) => new UpdateCustomHostnameResponseJsonValue(value);

        /// <summary>
        ///
        /// </summary>
        public UpdateCustomHostnameResponseJsonValue(
            global::Supabase.AnyOf<string, double?, bool?>? updateCustomHostnameResponseJsonValueVariant1,
            global::System.Collections.Generic.IList<global::Supabase.UpdateCustomHostnameResponseJsonValue>? updateCustomHostnameResponseJsonValueVariant2,
            object? updateCustomHostnameResponseJsonValueVariant3
            )
        {
            UpdateCustomHostnameResponseJsonValueVariant1 = updateCustomHostnameResponseJsonValueVariant1;
            UpdateCustomHostnameResponseJsonValueVariant2 = updateCustomHostnameResponseJsonValueVariant2;
            UpdateCustomHostnameResponseJsonValueVariant3 = updateCustomHostnameResponseJsonValueVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            UpdateCustomHostnameResponseJsonValueVariant3 as object ??
            UpdateCustomHostnameResponseJsonValueVariant2 as object ??
            UpdateCustomHostnameResponseJsonValueVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            UpdateCustomHostnameResponseJsonValueVariant1?.ToString() ??
            UpdateCustomHostnameResponseJsonValueVariant2?.ToString() ??
            UpdateCustomHostnameResponseJsonValueVariant3?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsUpdateCustomHostnameResponseJsonValueVariant1 || IsUpdateCustomHostnameResponseJsonValueVariant2 || IsUpdateCustomHostnameResponseJsonValueVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Supabase.AnyOf<string, double?, bool?>?, TResult>? updateCustomHostnameResponseJsonValueVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Supabase.UpdateCustomHostnameResponseJsonValue>, TResult>? updateCustomHostnameResponseJsonValueVariant2 = null,
            global::System.Func<object, TResult>? updateCustomHostnameResponseJsonValueVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUpdateCustomHostnameResponseJsonValueVariant1 && updateCustomHostnameResponseJsonValueVariant1 != null)
            {
                return updateCustomHostnameResponseJsonValueVariant1(UpdateCustomHostnameResponseJsonValueVariant1!);
            }
            else if (IsUpdateCustomHostnameResponseJsonValueVariant2 && updateCustomHostnameResponseJsonValueVariant2 != null)
            {
                return updateCustomHostnameResponseJsonValueVariant2(UpdateCustomHostnameResponseJsonValueVariant2!);
            }
            else if (IsUpdateCustomHostnameResponseJsonValueVariant3 && updateCustomHostnameResponseJsonValueVariant3 != null)
            {
                return updateCustomHostnameResponseJsonValueVariant3(UpdateCustomHostnameResponseJsonValueVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Supabase.AnyOf<string, double?, bool?>?>? updateCustomHostnameResponseJsonValueVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::Supabase.UpdateCustomHostnameResponseJsonValue>>? updateCustomHostnameResponseJsonValueVariant2 = null,

            global::System.Action<object>? updateCustomHostnameResponseJsonValueVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUpdateCustomHostnameResponseJsonValueVariant1)
            {
                updateCustomHostnameResponseJsonValueVariant1?.Invoke(UpdateCustomHostnameResponseJsonValueVariant1!);
            }
            else if (IsUpdateCustomHostnameResponseJsonValueVariant2)
            {
                updateCustomHostnameResponseJsonValueVariant2?.Invoke(UpdateCustomHostnameResponseJsonValueVariant2!);
            }
            else if (IsUpdateCustomHostnameResponseJsonValueVariant3)
            {
                updateCustomHostnameResponseJsonValueVariant3?.Invoke(UpdateCustomHostnameResponseJsonValueVariant3!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Supabase.AnyOf<string, double?, bool?>?>? updateCustomHostnameResponseJsonValueVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Supabase.UpdateCustomHostnameResponseJsonValue>>? updateCustomHostnameResponseJsonValueVariant2 = null,
            global::System.Action<object>? updateCustomHostnameResponseJsonValueVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUpdateCustomHostnameResponseJsonValueVariant1)
            {
                updateCustomHostnameResponseJsonValueVariant1?.Invoke(UpdateCustomHostnameResponseJsonValueVariant1!);
            }
            else if (IsUpdateCustomHostnameResponseJsonValueVariant2)
            {
                updateCustomHostnameResponseJsonValueVariant2?.Invoke(UpdateCustomHostnameResponseJsonValueVariant2!);
            }
            else if (IsUpdateCustomHostnameResponseJsonValueVariant3)
            {
                updateCustomHostnameResponseJsonValueVariant3?.Invoke(UpdateCustomHostnameResponseJsonValueVariant3!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UpdateCustomHostnameResponseJsonValueVariant1,
                typeof(global::Supabase.AnyOf<string, double?, bool?>),
                UpdateCustomHostnameResponseJsonValueVariant2,
                typeof(global::System.Collections.Generic.IList<global::Supabase.UpdateCustomHostnameResponseJsonValue>),
                UpdateCustomHostnameResponseJsonValueVariant3,
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
        public bool Equals(UpdateCustomHostnameResponseJsonValue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Supabase.AnyOf<string, double?, bool?>?>.Default.Equals(UpdateCustomHostnameResponseJsonValueVariant1, other.UpdateCustomHostnameResponseJsonValueVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Supabase.UpdateCustomHostnameResponseJsonValue>?>.Default.Equals(UpdateCustomHostnameResponseJsonValueVariant2, other.UpdateCustomHostnameResponseJsonValueVariant2) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(UpdateCustomHostnameResponseJsonValueVariant3, other.UpdateCustomHostnameResponseJsonValueVariant3)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(UpdateCustomHostnameResponseJsonValue obj1, UpdateCustomHostnameResponseJsonValue obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateCustomHostnameResponseJsonValue>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UpdateCustomHostnameResponseJsonValue obj1, UpdateCustomHostnameResponseJsonValue obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateCustomHostnameResponseJsonValue o && Equals(o);
        }
    }
}
