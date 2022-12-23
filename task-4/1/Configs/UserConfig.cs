namespace Configs
{
    internal static class UserConfig
    {
        public const int FirstNameLength = 50;
        public const int LastNameLength = 200;
        public const int LoginLength = 20;

        public const string FirstNamePattern = @"(?:^[À-ß¨][à-ÿ¸À-ß¨]*)$|(?:^[A-Z][a-zA-Z]*)$";
        public const string LastNamePattern =  @"(?:^[A-Z](?:\-[A-Z]|[a-zA-Z])*)$|(?:^[À-ß¨](?:\-[À-ß¨]|[à-ÿ¸À-ß¨])*)$";
        public const string EmailPattern =     @"(?:^[a-zA-Z0-9](?:[a-zA-Z0-9\-_]*[a-zA-Z0-9])?)@" +
                                               @"(?:[a-zA-Z0-9](?:[a-zA-Z0-9\-_]*[a-zA-Z0-9])?\.)+(?:[a-zA-Z]{2,6})$";
        public const string LoginPattern =     @"^(?:[a-zA-Z])*$";

        public const string ErrorStart =       "Error! Please check your entered info for this requirements:\n\n";
        public const string FirstNameFormat =  "Name - contains Russian or Latin characters (one name cannot contain both) " +
                                               "starts with a capital letter. Maximum number of characters 50.Required field.";
        public const string LastNameFormat =   "Surname - contains Russian or Latin characters (both cannot be present in the " +
                                               "same surname), begins with a capital letter. The maximum number of characters 200 " +
                                               "Can contain a hyphen, in this case the first character after the hyphenis uppercase." +
                                               " A hyphen cannot be the first or last character. Required field.";
        public const string EmailFormat =      "Email - the mailbox name can contain letters, numbers, a period, a hyphen and an " +
                                               "underscore, and the first and last characters can only be letters or numbers. The same" +
                                               " rules apply for subdomain names, but the dot is not valid. The first-level domain name " +
                                               "can consist only of letters in the number from 2 to 6. Optional field.";
        public const string LoginFormat =      "Login - contains Latin characters. The maximum number of characters is 20. Required field.";
        public const string BirthFormat =      "BirthDate cant be more than now time.Optional field.";
        public const string DateFormat =       "DateTime has been not found.";
    }
}