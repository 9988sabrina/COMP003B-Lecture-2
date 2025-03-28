﻿namespace COMP003B_Lecture_2.Middleware
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine($"[request] {context.Request.Method} {context.Request.Path}");
            await _next(context);
            Console.WriteLine($"[Response] {context.Response.StatusCode}");
        }
    }
}
