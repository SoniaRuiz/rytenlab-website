using System;

namespace RytenLab_Web.Models
{
    public class ErrorViewModel
    {
        public string Message { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(Message);
    }
}