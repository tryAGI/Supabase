
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum AuthConfigResponseOutputPasswordRequiredCharacters
    {
        /// <summary>
        ///
        /// </summary>
        Abcdefghijklmnopqrstuvwxyz_ABCDEFGHIJKLMNOPQRSTUVWXYZ_0123456789,
        /// <summary>
        ///
        /// </summary>
        Abcdefghijklmnopqrstuvwxyz_ABCDEFGHIJKLMNOPQRSTUVWXYZ_0123456789________AnyPlus_Array______________,
        /// <summary>
        ///
        /// </summary>
        AbcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ_0123456789,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthConfigResponseOutputPasswordRequiredCharactersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthConfigResponseOutputPasswordRequiredCharacters value)
        {
            return value switch
            {
                AuthConfigResponseOutputPasswordRequiredCharacters.Abcdefghijklmnopqrstuvwxyz_ABCDEFGHIJKLMNOPQRSTUVWXYZ_0123456789 => "abcdefghijklmnopqrstuvwxyz:ABCDEFGHIJKLMNOPQRSTUVWXYZ:0123456789",
                AuthConfigResponseOutputPasswordRequiredCharacters.Abcdefghijklmnopqrstuvwxyz_ABCDEFGHIJKLMNOPQRSTUVWXYZ_0123456789________AnyPlus_Array______________ => "abcdefghijklmnopqrstuvwxyz:ABCDEFGHIJKLMNOPQRSTUVWXYZ:0123456789:!@#$%^&*()_+-=[]{};'\\\\:\"|<>?,./`~",
                AuthConfigResponseOutputPasswordRequiredCharacters.AbcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ_0123456789 => "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ:0123456789",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthConfigResponseOutputPasswordRequiredCharacters? ToEnum(string value)
        {
            return value switch
            {
                "abcdefghijklmnopqrstuvwxyz:ABCDEFGHIJKLMNOPQRSTUVWXYZ:0123456789" => AuthConfigResponseOutputPasswordRequiredCharacters.Abcdefghijklmnopqrstuvwxyz_ABCDEFGHIJKLMNOPQRSTUVWXYZ_0123456789,
                "abcdefghijklmnopqrstuvwxyz:ABCDEFGHIJKLMNOPQRSTUVWXYZ:0123456789:!@#$%^&*()_+-=[]{};'\\\\:\"|<>?,./`~" => AuthConfigResponseOutputPasswordRequiredCharacters.Abcdefghijklmnopqrstuvwxyz_ABCDEFGHIJKLMNOPQRSTUVWXYZ_0123456789________AnyPlus_Array______________,
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ:0123456789" => AuthConfigResponseOutputPasswordRequiredCharacters.AbcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ_0123456789,
                _ => null,
            };
        }
    }
}