
namespace todo_app_csharp
{
    class Member
    {
        //TODO: create a member collection
        private string _firstName;
        private string _lastName;
        private int _id;

        public Member(int id, string fname, string lname) {
            this._firstName = fname;
            this._lastName = lname;
            this._id = id;
        }
    }    
    
}