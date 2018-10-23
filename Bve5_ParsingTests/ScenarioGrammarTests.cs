using System;
using Xunit;
using Bve5_Parsing.ScenarioGrammar;
using System.Collections.Generic;
using System.Collections;

namespace Bve5_ParsingTests
{
    /// <summary>
    /// �V�i���I�\���̃e�X�g
    /// </summary>
    public class ScenarioGrammarTests
    {
        /// <summary>
        /// �����ɗ^����ꂽ�\����������p�[�X���܂��B
        /// </summary>
        /// <param name="input">�}�b�v�\��</param>
        /// <returns>MapData</returns>
        private ScenarioData ExecParse(string input)
        {
            var mParser = new ScenarioGrammarParser();
            ScenarioData data = null;
            try
            {
                data = mParser.Parse(input);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message + ":" + e.StackTrace);
            }

            return data;
        }

        /// <summary>
        /// Assert.NotNull��Assert.Equal�����s���܂��B
        /// </summary>
        /// <param name="expected">�p�[�T�ɂ���Đ������ꂽScenarioData</param>
        /// <param name="actual">�m�F�p</param>
        private void Check(ScenarioData expected, ScenarioData actual)
        {
            Assert.NotNull(expected);
            Assert.Equal(expected, actual);
        }

        #region �e�\���̃e�X�g
        [Fact]
        public void RootTest()
        {
            // �����F�G���R�[�h�w��̑O��ɂ͋󔒂͓�����Ȃ��͂������A�o���Ă��܂�
            Check(
                ExecParse("BveTs Scenario 1.00"),
                new ScenarioData() { Version = "1.00" });
            Check(
                ExecParse("BveTs Scenario 1.00:shift_jis"),
                new ScenarioData() { Version = "1.00", Encoding = "shift_jis" });
            Check(
                ExecParse("bVETS sCeNARIO 1.00:ShiFt_Jis"),
                new ScenarioData() { Version = "1.00", Encoding = "ShiFt_Jis" });
        }
        #endregion
    }
}
