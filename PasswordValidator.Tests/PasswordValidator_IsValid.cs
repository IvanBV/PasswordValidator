using Xunit;
using PasswordValidator;

namespace PasswordValidator
{
    public class PasswordValidator_IsValid
    {
        [Theory]
        [InlineData("P1zz@")]
        [InlineData("P1zz@P1zz@P1zz@P1zz@P1zz@")]
        [InlineData("mypassword11")]
        [InlineData("MYPASSWORD11")]
        [InlineData("iLoveYou")]
        [InlineData("Pè7$areLove")]
        [InlineData("Repeeea7!")]
        public void IsValid_ReturnsFalse(string password)
        {
            Assert.False(PasswordValidator.ValidatePassword(password), $"Password {password} should be invalid");
        }

        [Theory]
        [InlineData("H4(k+x0")]
        [InlineData("Fhg93@")]
        [InlineData("aA0!@#$%^&*()+=_-{}[]:;\"")]
        [InlineData("zZ9'?<>,.")]
        public void IsValid_ReturnsTrue(string password)
        {
            Assert.True(PasswordValidator.ValidatePassword(password), $"Password {password} should be valid");
        }
    }
}