using EnglishWordSet.Controllers;


namespace EnglishWordSet.util
{
    static class ControllersGetter
    {
        private static UserController adminPageBackend;
        private static LoginController loginPageBackend;
        private static MBWordController mBWordPageBackend;
        private static LearnedWordsController learnedWordsPageBackend;

        public static UserController AdminPage() => adminPageBackend ??= new();

        public static LoginController LoginPage() => loginPageBackend ??= new();

        public static MBWordController mBWordPage() => mBWordPageBackend ??= new();
    
        public static LearnedWordsController LearnedPAge() => learnedWordsPageBackend ??= new();

    }
}
