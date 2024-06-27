namespace BasePlatform.API.Users
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public void Add(User users)
        {
            _userRepository.Add(users);
        }

        public void Update(User users)
        {
            _userRepository.Update(users);
        }

        public void Delete(int id)
        {
            _userRepository.Delete(id);
        }
    }
}