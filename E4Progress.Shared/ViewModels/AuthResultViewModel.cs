using System;

namespace E4Progress.Shared.ViewModels
{
   public class AuthResultViewModel
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public string Errors { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string Token { get; set; }
    }
}
