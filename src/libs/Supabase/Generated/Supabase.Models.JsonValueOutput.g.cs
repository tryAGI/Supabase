#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Supabase
{
    /// <summary>
    /// Any JSON-serializable value
    /// </summary>
    public readonly partial struct JsonValueOutput : global::System.IEquatable<JsonValueOutput>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Supabase.AnyOf<string, double?, bool?>? JsonValueOutputVariant1 { get; init; }
#else
        public global::Supabase.AnyOf<string, double?, bool?>? JsonValueOutputVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonValueOutputVariant1))]
#endif
        public bool IsJsonValueOutputVariant1 => JsonValueOutputVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickJsonValueOutputVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Supabase.AnyOf<string, double?, bool?>? value)
        {
            value = JsonValueOutputVariant1;
            return IsJsonValueOutputVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Supabase.AnyOf<string, double?, bool?> PickJsonValueOutputVariant1() => IsJsonValueOutputVariant1
            ? JsonValueOutputVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'JsonValueOutputVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Supabase.JsonValueOutput>? JsonValueOutputVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Supabase.JsonValueOutput>? JsonValueOutputVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonValueOutputVariant2))]
#endif
        public bool IsJsonValueOutputVariant2 => JsonValueOutputVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickJsonValueOutputVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Supabase.JsonValueOutput>? value)
        {
            value = JsonValueOutputVariant2;
            return IsJsonValueOutputVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.JsonValueOutput> PickJsonValueOutputVariant2() => IsJsonValueOutputVariant2
            ? JsonValueOutputVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'JsonValueOutputVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.Dictionary<string, global::Supabase.JsonValueOutput>? JsonValueOutputVariant3 { get; init; }
#else
        public global::System.Collections.Generic.Dictionary<string, global::Supabase.JsonValueOutput>? JsonValueOutputVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonValueOutputVariant3))]
#endif
        public bool IsJsonValueOutputVariant3 => JsonValueOutputVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickJsonValueOutputVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.Dictionary<string, global::Supabase.JsonValueOutput>? value)
        {
            value = JsonValueOutputVariant3;
            return IsJsonValueOutputVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Supabase.JsonValueOutput> PickJsonValueOutputVariant3() => IsJsonValueOutputVariant3
            ? JsonValueOutputVariant3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'JsonValueOutputVariant3' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator JsonValueOutput(global::Supabase.AnyOf<string, double?, bool?> value) => new JsonValueOutput((global::Supabase.AnyOf<string, double?, bool?>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Supabase.AnyOf<string, double?, bool?>?(JsonValueOutput @this) => @this.JsonValueOutputVariant1;

        /// <summary>
        ///
        /// </summary>
        public JsonValueOutput(global::Supabase.AnyOf<string, double?, bool?>? value)
        {
            JsonValueOutputVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static JsonValueOutput FromJsonValueOutputVariant1(global::Supabase.AnyOf<string, double?, bool?>? value) => new JsonValueOutput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator JsonValueOutput(global::System.Collections.Generic.Dictionary<string, global::Supabase.JsonValueOutput> value) => new JsonValueOutput((global::System.Collections.Generic.Dictionary<string, global::Supabase.JsonValueOutput>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::System.Collections.Generic.Dictionary<string, global::Supabase.JsonValueOutput>?(JsonValueOutput @this) => @this.JsonValueOutputVariant3;

        /// <summary>
        ///
        /// </summary>
        public JsonValueOutput(global::System.Collections.Generic.Dictionary<string, global::Supabase.JsonValueOutput>? value)
        {
            JsonValueOutputVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static JsonValueOutput FromJsonValueOutputVariant3(global::System.Collections.Generic.Dictionary<string, global::Supabase.JsonValueOutput>? value) => new JsonValueOutput(value);

        /// <summary>
        ///
        /// </summary>
        public JsonValueOutput(
            global::Supabase.AnyOf<string, double?, bool?>? jsonValueOutputVariant1,
            global::System.Collections.Generic.IList<global::Supabase.JsonValueOutput>? jsonValueOutputVariant2,
            global::System.Collections.Generic.Dictionary<string, global::Supabase.JsonValueOutput>? jsonValueOutputVariant3
            )
        {
            JsonValueOutputVariant1 = jsonValueOutputVariant1;
            JsonValueOutputVariant2 = jsonValueOutputVariant2;
            JsonValueOutputVariant3 = jsonValueOutputVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            JsonValueOutputVariant3 as object ??
            JsonValueOutputVariant2 as object ??
            JsonValueOutputVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            JsonValueOutputVariant1?.ToString() ??
            JsonValueOutputVariant2?.ToString() ??
            JsonValueOutputVariant3?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsJsonValueOutputVariant1 || IsJsonValueOutputVariant2 || IsJsonValueOutputVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Supabase.AnyOf<string, double?, bool?>?, TResult>? jsonValueOutputVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Supabase.JsonValueOutput>, TResult>? jsonValueOutputVariant2 = null,
            global::System.Func<global::System.Collections.Generic.Dictionary<string, global::Supabase.JsonValueOutput>, TResult>? jsonValueOutputVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJsonValueOutputVariant1 && jsonValueOutputVariant1 != null)
            {
                return jsonValueOutputVariant1(JsonValueOutputVariant1!);
            }
            else if (IsJsonValueOutputVariant2 && jsonValueOutputVariant2 != null)
            {
                return jsonValueOutputVariant2(JsonValueOutputVariant2!);
            }
            else if (IsJsonValueOutputVariant3 && jsonValueOutputVariant3 != null)
            {
                return jsonValueOutputVariant3(JsonValueOutputVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Supabase.AnyOf<string, double?, bool?>?>? jsonValueOutputVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::Supabase.JsonValueOutput>>? jsonValueOutputVariant2 = null,

            global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Supabase.JsonValueOutput>>? jsonValueOutputVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJsonValueOutputVariant1)
            {
                jsonValueOutputVariant1?.Invoke(JsonValueOutputVariant1!);
            }
            else if (IsJsonValueOutputVariant2)
            {
                jsonValueOutputVariant2?.Invoke(JsonValueOutputVariant2!);
            }
            else if (IsJsonValueOutputVariant3)
            {
                jsonValueOutputVariant3?.Invoke(JsonValueOutputVariant3!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Supabase.AnyOf<string, double?, bool?>?>? jsonValueOutputVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Supabase.JsonValueOutput>>? jsonValueOutputVariant2 = null,
            global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Supabase.JsonValueOutput>>? jsonValueOutputVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJsonValueOutputVariant1)
            {
                jsonValueOutputVariant1?.Invoke(JsonValueOutputVariant1!);
            }
            else if (IsJsonValueOutputVariant2)
            {
                jsonValueOutputVariant2?.Invoke(JsonValueOutputVariant2!);
            }
            else if (IsJsonValueOutputVariant3)
            {
                jsonValueOutputVariant3?.Invoke(JsonValueOutputVariant3!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                JsonValueOutputVariant1,
                typeof(global::Supabase.AnyOf<string, double?, bool?>),
                JsonValueOutputVariant2,
                typeof(global::System.Collections.Generic.IList<global::Supabase.JsonValueOutput>),
                JsonValueOutputVariant3,
                typeof(global::System.Collections.Generic.Dictionary<string, global::Supabase.JsonValueOutput>),
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
        public bool Equals(JsonValueOutput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Supabase.AnyOf<string, double?, bool?>?>.Default.Equals(JsonValueOutputVariant1, other.JsonValueOutputVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Supabase.JsonValueOutput>?>.Default.Equals(JsonValueOutputVariant2, other.JsonValueOutputVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.Dictionary<string, global::Supabase.JsonValueOutput>?>.Default.Equals(JsonValueOutputVariant3, other.JsonValueOutputVariant3)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(JsonValueOutput obj1, JsonValueOutput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<JsonValueOutput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(JsonValueOutput obj1, JsonValueOutput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is JsonValueOutput o && Equals(o);
        }
    }
}
