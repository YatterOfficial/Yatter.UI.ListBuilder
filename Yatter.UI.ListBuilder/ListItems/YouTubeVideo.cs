﻿using System;
namespace Yatter.UI.ListBuilder.ListItems
{
    public class YouTubeVideo : TextBase, IDataType
    {
        public string VideoWatchUrl { get; set; }
        public string Base64YouTubeLogo { get; set; } = "PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0idXRmLTgiPz4KPCEtLSBHZW5lcmF0b3I6IEFkb2JlIElsbHVzdHJhdG9yIDIxLjAuMCwgU1ZHIEV4cG9ydCBQbHVnLUluIC4gU1ZHIFZlcnNpb246IDYuMDAgQnVpbGQgMCkgIC0tPgo8c3ZnIHZlcnNpb249IjEuMSIgaWQ9IllvdVR1YmVfSWNvbiIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB4bWxuczp4bGluaz0iaHR0cDovL3d3dy53My5vcmcvMTk5OS94bGluayIgeD0iMHB4IgoJIHk9IjBweCIgdmlld0JveD0iMCAwIDEwMjQgNzIxIiBlbmFibGUtYmFja2dyb3VuZD0ibmV3IDAgMCAxMDI0IDcyMSIgeG1sOnNwYWNlPSJwcmVzZXJ2ZSI+CjxwYXRoIGlkPSJUcmlhbmdsZSIgZmlsbD0iI0ZGRkZGRiIgZD0iTTQwNyw0OTNsMjc2LTE0M0w0MDcsMjA2VjQ5M3oiLz4KPHBhdGggaWQ9IlRoZV9TaGFycG5lc3MiIG9wYWNpdHk9IjAuMTIiIGZpbGw9IiM0MjAwMDAiIGQ9Ik00MDcsMjA2bDI0MiwxNjEuNmwzNC0xNy42TDQwNywyMDZ6Ii8+CjxnIGlkPSJMb3plbmdlIj4KCTxnPgoJCQoJCQk8bGluZWFyR3JhZGllbnQgaWQ9IlNWR0lEXzFfIiBncmFkaWVudFVuaXRzPSJ1c2VyU3BhY2VPblVzZSIgeDE9IjUxMi41IiB5MT0iNzE5LjciIHgyPSI1MTIuNSIgeTI9IjEuMiIgZ3JhZGllbnRUcmFuc2Zvcm09Im1hdHJpeCgxIDAgMCAtMSAwIDcyMSkiPgoJCQk8c3RvcCAgb2Zmc2V0PSIwIiBzdHlsZT0ic3RvcC1jb2xvcjojRTUyRDI3Ii8+CgkJCTxzdG9wICBvZmZzZXQ9IjEiIHN0eWxlPSJzdG9wLWNvbG9yOiNCRjE3MUQiLz4KCQk8L2xpbmVhckdyYWRpZW50PgoJCTxwYXRoIGZpbGw9InVybCgjU1ZHSURfMV8pIiBkPSJNMTAxMywxNTYuM2MwLDAtMTAtNzAuNC00MC42LTEwMS40QzkzMy42LDE0LjIsODkwLDE0LDg3MC4xLDExLjZDNzI3LjEsMS4zLDUxMi43LDEuMyw1MTIuNywxLjMKCQkJaC0wLjRjMCwwLTIxNC40LDAtMzU3LjQsMTAuM0MxMzUsMTQsOTEuNCwxNC4yLDUyLjYsNTQuOUMyMiw4NS45LDEyLDE1Ni4zLDEyLDE1Ni4zUzEuOCwyMzguOSwxLjgsMzIxLjZ2NzcuNQoJCQlDMS44LDQ4MS44LDEyLDU2NC40LDEyLDU2NC40czEwLDcwLjQsNDAuNiwxMDEuNGMzOC45LDQwLjcsODkuOSwzOS40LDExMi42LDQzLjdjODEuNyw3LjgsMzQ3LjMsMTAuMywzNDcuMywxMC4zCgkJCXMyMTQuNi0wLjMsMzU3LjYtMTAuN2MyMC0yLjQsNjMuNS0yLjYsMTAyLjMtNDMuM2MzMC42LTMxLDQwLjYtMTAxLjQsNDAuNi0xMDEuNHMxMC4yLTgyLjcsMTAuMi0xNjUuM3YtNzcuNQoJCQlDMTAyMy4yLDIzOC45LDEwMTMsMTU2LjMsMTAxMywxNTYuM3ogTTQwNyw0OTNWMjA2bDI3NiwxNDRMNDA3LDQ5M3oiLz4KCTwvZz4KPC9nPgo8L3N2Zz4=";
        public string ImageSpecification { get; set; } = "svg+xml";

        public YouTubeVideo()
        {
            DataType = GetType().ToString();
        }
    }
}
