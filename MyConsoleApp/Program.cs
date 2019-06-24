using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
//            var workflow= new Workflow();
//            workflow.RegisterActivity(new Uploading());
//            workflow.RegisterActivity(new Calling());
//            workflow.RegisterActivity(new SendingEmail());
//            workflow.RegisterActivity(new ChangingVideoStatus());
//
//            var engine = new WorkflowEngine();
//            engine.Run(workflow);

            var sqlConnection = new SqlConnection("https://localhost/mySqlConnection");
            
            var dbCommand = new DbCommand(sqlConnection, "instruction");
            dbCommand.Execute();
            
            var oracleConnection = new OracleConnection("https://localhost/myOracleConnection");
            var dbCommand1 = new DbCommand(oracleConnection, "instruction");
            dbCommand1.Execute();

            Console.WriteLine("OracleConnection timeout: " + oracleConnection.Timeout);
            oracleConnection.OpenConnection();
            oracleConnection.CloseConnection();

            //            var stack = new Stack(new ArrayList());
            //
            //            for(var i = 1; i <= 5; i++)
            //                stack.Push(i);
            //
            //            for (var i = 0; i < 5; i++)
            //                Console.WriteLine(stack.Pop());

            //            var stopwatch = new Stopwatch();
            //            DisplayStopwatchDuration(stopwatch);

//            var post = new Post();
//            DisplayPostVotes(post);
        }

        private static void DisplayPostVotes(Post post)
        {
            post.UpVotePost();
            post.UpVotePost();
            post.UpVotePost();
            post.UpVotePost();

            post.DownVotePost();
            post.DownVotePost();

            Console.WriteLine("Votes: " + post.Vote);
        }

//        private static void DisplayStopwatchDuration(Stopwatch stopwatch)
//        {
//            for (var i = 0; i < 2; i++)
//            {
//                stopwatch.Start();
//
//                Thread.Sleep(1000);
//
//                stopwatch.Stop();
//
//                Console.WriteLine("Duration: {0} milisecond/s", stopwatch.Duration());
//
//                Console.WriteLine("Press enter to run the stopwatch one more time..");
//                Console.ReadLine();
//            }
//        }
    }
}
