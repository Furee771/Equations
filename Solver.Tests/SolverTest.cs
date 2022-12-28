namespace Solver.Tests
{
    [TestClass] // <= так нужно поменять класс, чтобы система тестирования начал искать в нем
    public class SolverTest
    {
        void TestEquation(double a, double b, double c, params double[] expectedResult)
        {
            var result = QuadraticEquationsSolver.Solve(a, b, c);
            Assert.AreEqual(expectedResult.Length, result.Length);

            for(int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], result[i]);
            }
        }
        [TestMethod] // <= так нужно поменять метод, чтобы система тестирования понял, что это тесты.
        public void OrdinaryEqation() // что метод не статический.  
        {
            TestEquation(1, -3, 2, 2, 1);
        }
        [TestMethod]
        public void NegativeDiscriminant()
        {
            TestEquation(1, 1, 1);
        }

        [TestMethod]
        public void ZeroDiscriminant()
        {
            TestEquation(1, 2, 1, -1);
        }
    }
}