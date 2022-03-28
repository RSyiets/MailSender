using System;
using System.Linq;

namespace MailSender {
    class Option {
        private const string dryrunOption = "-d";

        private static Option option;
        private readonly bool dryrun;

        private Option(string[] args) {
            dryrun = args.Contains(dryrunOption);
        }

        public static void Initialize(string[] args) {
            option = new Option(args);
        }

        public static bool Dryrun {
            get {
                return option.dryrun;
            }
        }
    }
}
