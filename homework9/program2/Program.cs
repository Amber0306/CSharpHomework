using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace program2
{
    class Crawler
    {
        private Hashtable urls = new Hashtable();
        private int count = 0;

        static void Main(string[] args)
        {
            Crawler myCrawler = new Crawler();
            string startUrl = "http://www.cnblogs.com/dstang2000/";
            if (args.Length >= 1) startUrl = args[0];

            myCrawler.urls.Add(startUrl, false);//加入初始界面
            Stopwatch sw = new Stopwatch();
            sw.Start();
            new Thread(myCrawler.Crawl).Start();//开始爬行
            sw.Stop();
            Console.WriteLine("并行用时："+sw.ElapsedMilliseconds);
            sw.Start();
            new Thread(myCrawler.CrawlNormal).Start();//开始爬行
            sw.Stop();
            Console.WriteLine("普通用时：" + sw.ElapsedMilliseconds);
        }

        private void Crawl()
        {
            Console.WriteLine("开始爬行了");
            Parallel.For(0, 10, count =>
              {
                  string current = null;
                  foreach (string url in urls.Keys)                              //找到一个还没有下载过的链接
                  {
                      if ((bool)urls[url]) continue;                               //已经下载过的，不再下载
                      current = url;
                  }            
                  //if (current == null || count > 10) break;
                  Console.WriteLine("爬行" + current + "页面！");
                  string html = Download(current);                         //下载
                  urls[current] = true;                  
                  Parse(html);                                                          //解析
                  Console.WriteLine("count = {0}, thread id={1}",count,Thread.CurrentThread.ManagedThreadId);
              });
            Console.WriteLine("爬行结束！");
            Console.ReadLine();
        }

        private void CrawlNormal()
        {
            Console.WriteLine("开始爬行了");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)                              //找到一个还没有下载过的链接
                {
                    if ((bool)urls[url]) continue;                               //已经下载过的，不再下载
                    current = url;
                }
                if (current == null || count > 10) break;
                Console.WriteLine("爬行" + current + "页面！");
                string html = Download(current);                         //下载
                urls[current] = true;
                Parse(html);                                                          //解析   
             }
            Console.WriteLine("爬行结束！");
        }

        private string Download(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch(Exception e)
            {
                // throw new NotImplementedException();
                Console.WriteLine(e.Message);
                return null;
            }
        }

        private void Parse(string html)
        {
            try
            {
                string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
                MatchCollection matches = new Regex(strRef).Matches(html);
                foreach(Match match in matches)
                {
                    strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '/' , '#',' ', '>');
                     if(strRef.Length==0){ continue; }
                    if (urls[strRef] == null) { urls[strRef] = false; }
                }
            }
            catch(Exception e)
            {
                //throw new NotImplementedException();
                Console.WriteLine(e.Message);
            }
        }     
    }
}
