using Xunit;
using TreehouseDefense;

namespace TreehouseDefense.Tests.Mocks
{
    class InvaderMock : IInvader
    {
        public MapLocation Location { get; set;  }

        public bool HasScored => false;

        public int Health { get; private set; } = 2;

        public bool IsNeutralized => false;

        public bool IsActive => true;

        public void DecreaseHealth(int factor)
        {
            Health -= factor;
        }

        public void Move()
        {
            throw new System.NotImplementedException();
        }
    }

    // auto-generated
    //class InvaderMock : IInvader
    //{
    //    public MapLocation Location => throw new System.NotImplementedException();

    //    public bool HasScored => throw new System.NotImplementedException();

    //    public int Health => throw new System.NotImplementedException();

    //    public bool IsNeutralized => throw new System.NotImplementedException();

    //    public bool IsActive => throw new System.NotImplementedException();

    //    public void DecreaseHealth(int factor)
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public void Move()
    //    {
    //        throw new System.NotImplementedException();
    //    }
    //}
}
