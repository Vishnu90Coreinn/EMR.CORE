namespace EMR.CORE.Application.Identity.Tokens;

public record RefreshTokenRequest(string Token, string RefreshToken);