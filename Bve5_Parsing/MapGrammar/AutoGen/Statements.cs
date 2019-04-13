/*
 * このファイルはdoc/createMapGrammarTemplate.jsによって自動生成されています。
 * 編集は行わないでください。
 */
using Bve5_Parsing.MapGrammar.Attributes;

namespace Bve5_Parsing.MapGrammar.EvaluateData {

    /// <summary>
    /// Curve.Setgauge(Value);
    /// </summary>
    public partial class CurveSetgaugeStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Curve;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Setgauge;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：軌間 [m]
        /// </summary>
        [Argument]
        public double Value { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Curve.Gauge(Value);
    /// </summary>
    public partial class CurveGaugeStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Curve;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Gauge;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：軌間 [m]
        /// </summary>
        [Argument]
        public double Value { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Curve.Setcenter(X);
    /// </summary>
    public partial class CurveSetcenterStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Curve;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Setcenter;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：回転中心の x 座標 [m] (正: 曲線の内側, 負: 曲線の外側)
        /// </summary>
        [Argument]
        public double X { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Curve.Setfunction(Id);
    /// </summary>
    public partial class CurveSetfunctionStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Curve;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Setfunction;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：関数番号 (0: サイン半波長逓減, 1: 直線逓減)
        /// </summary>
        [Argument]
        public double Id { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Curve.Begintransition();
    /// </summary>
    public partial class CurveBegintransitionStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Curve;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Begintransition;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo


    }

    /// <summary>
    /// Curve.Begin(Radius, Cant?);
    /// </summary>
    public partial class CurveBeginStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Curve;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Begin;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：曲線半径 [m] (正: 右曲線, 負: 左曲線)
        /// </summary>
        [Argument]
        public double Radius { get; set; }

        /// <summary>
        /// 引数：カント [m]（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double Cant { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Curve.Begincircular(Radius, Cant?);
    /// </summary>
    public partial class CurveBegincircularStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Curve;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Begincircular;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：曲線半径 [m] (正: 右曲線, 負: 左曲線)
        /// </summary>
        [Argument]
        public double Radius { get; set; }

        /// <summary>
        /// 引数：カント [m]（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double Cant { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Curve.End();
    /// </summary>
    public partial class CurveEndStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Curve;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.End;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo


    }

    /// <summary>
    /// Curve.Interpolate(Radius?, Cant?);
    /// </summary>
    public partial class CurveInterpolateStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Curve;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Interpolate;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：曲線半径 [m] (正: 右曲線, 負: 左曲線, 0: 直線)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double Radius { get; set; }

        /// <summary>
        /// 引数：カント [m]（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double Cant { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Curve.Change(Radius);
    /// </summary>
    public partial class CurveChangeStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Curve;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Change;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：曲線半径 [m] (正: 右曲線, 負: 左曲線, 0: 直線)
        /// </summary>
        [Argument]
        public double Radius { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Gradient.Begintransition();
    /// </summary>
    public partial class GradientBegintransitionStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Gradient;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Begintransition;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo


    }

    /// <summary>
    /// Gradient.Begin(Gradient);
    /// </summary>
    public partial class GradientBeginStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Gradient;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Begin;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：勾配 [‰]
        /// </summary>
        [Argument]
        public double Gradient { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Gradient.Beginconst(Gradient);
    /// </summary>
    public partial class GradientBeginconstStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Gradient;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Beginconst;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：勾配 [‰]
        /// </summary>
        [Argument]
        public double Gradient { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Gradient.End();
    /// </summary>
    public partial class GradientEndStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Gradient;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.End;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo


    }

    /// <summary>
    /// Gradient.Interpolate(Gradient?);
    /// </summary>
    public partial class GradientInterpolateStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Gradient;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Interpolate;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：勾配 [‰]（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double Gradient { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Track[TrackKey].X.Interpolate(X?, Radius?);
    /// </summary>
    public partial class TrackXInterpolateStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Track;

        /// <summary>
        /// マップ副要素名
        /// </summary>
        public MapSubElementName SubElementName => MapSubElementName.X;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Interpolate;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => true;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：TrackKey
        /// </summary>
        public string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：自軌道からの x 座標 [m]（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double X { get; set; }

        /// <summary>
        /// 引数：現在の距離程以降の自軌道との平面曲線相対半径 [m] (0: 直線)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double Radius { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Track[TrackKey].Y.Interpolate(Y?, Radius?);
    /// </summary>
    public partial class TrackYInterpolateStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Track;

        /// <summary>
        /// マップ副要素名
        /// </summary>
        public MapSubElementName SubElementName => MapSubElementName.Y;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Interpolate;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => true;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：TrackKey
        /// </summary>
        public string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：自軌道からの y 座標 [m]（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double Y { get; set; }

        /// <summary>
        /// 引数：現在の距離程以降の自軌道との縦曲線相対半径 [m] (0: 直線)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double Radius { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Track[TrackKey].Position(X, Y, RadiusH?, RadiusV?);
    /// </summary>
    public partial class TrackPositionStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Track;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Position;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：TrackKey
        /// </summary>
        public string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：自軌道からの x 座標 [m]
        /// </summary>
        [Argument]
        public double X { get; set; }

        /// <summary>
        /// 引数：自軌道からの y 座標 [m]
        /// </summary>
        [Argument]
        public double Y { get; set; }

        /// <summary>
        /// 引数：現在の距離程以降の自軌道との平面曲線相対半径 [m] (0: 直線)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double RadiusH { get; set; }

        /// <summary>
        /// 引数：現在の距離程以降の自軌道との縦曲線相対半径 [m] (0: 直線)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double RadiusV { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Track[TrackKey].Cant.Setgauge(Gauge);
    /// </summary>
    public partial class TrackCantSetgaugeStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Track;

        /// <summary>
        /// マップ副要素名
        /// </summary>
        public MapSubElementName SubElementName => MapSubElementName.Cant;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Setgauge;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => true;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：TrackKey
        /// </summary>
        public string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：軌間 [m]
        /// </summary>
        [Argument]
        public double Gauge { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Track[TrackKey].Gauge(Gauge);
    /// </summary>
    public partial class TrackGaugeStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Track;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Gauge;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：TrackKey
        /// </summary>
        public string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：軌間 [m]
        /// </summary>
        [Argument]
        public double Gauge { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Track[TrackKey].Cant.Setcenter(X);
    /// </summary>
    public partial class TrackCantSetcenterStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Track;

        /// <summary>
        /// マップ副要素名
        /// </summary>
        public MapSubElementName SubElementName => MapSubElementName.Cant;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Setcenter;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => true;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：TrackKey
        /// </summary>
        public string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：回転中心の x 座標 [m] (正: 曲線の内側, 負: 曲線の外側)
        /// </summary>
        [Argument]
        public double X { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Track[TrackKey].Cant.Setfunction(Id);
    /// </summary>
    public partial class TrackCantSetfunctionStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Track;

        /// <summary>
        /// マップ副要素名
        /// </summary>
        public MapSubElementName SubElementName => MapSubElementName.Cant;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Setfunction;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => true;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：TrackKey
        /// </summary>
        public string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：関数番号 (0: サイン半波長逓減, 1: 直線逓減)
        /// </summary>
        [Argument]
        public double Id { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Track[TrackKey].Cant.Begintransition();
    /// </summary>
    public partial class TrackCantBegintransitionStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Track;

        /// <summary>
        /// マップ副要素名
        /// </summary>
        public MapSubElementName SubElementName => MapSubElementName.Cant;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Begintransition;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => true;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：TrackKey
        /// </summary>
        public string Key { get; set; }


    }

    /// <summary>
    /// Track[TrackKey].Cant.Begin(Cant);
    /// </summary>
    public partial class TrackCantBeginStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Track;

        /// <summary>
        /// マップ副要素名
        /// </summary>
        public MapSubElementName SubElementName => MapSubElementName.Cant;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Begin;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => true;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：TrackKey
        /// </summary>
        public string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：カント [m] (正: 右に傾ける, 負: 左に傾ける)
        /// </summary>
        [Argument]
        public double Cant { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Track[TrackKey].Cant.End();
    /// </summary>
    public partial class TrackCantEndStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Track;

        /// <summary>
        /// マップ副要素名
        /// </summary>
        public MapSubElementName SubElementName => MapSubElementName.Cant;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.End;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => true;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：TrackKey
        /// </summary>
        public string Key { get; set; }


    }

    /// <summary>
    /// Track[TrackKey].Cant.Interpolate(Cant?);
    /// </summary>
    public partial class TrackCantInterpolateStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Track;

        /// <summary>
        /// マップ副要素名
        /// </summary>
        public MapSubElementName SubElementName => MapSubElementName.Cant;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Interpolate;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => true;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：TrackKey
        /// </summary>
        public string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：カント [m] (正: 右に傾ける, 負: 左に傾ける)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double Cant { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Track[TrackKey].Cant(Cant?);
    /// </summary>
    public partial class TrackCantStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Track;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Cant;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：TrackKey
        /// </summary>
        public string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：カント [m] (正: 右に傾ける, 負: 左に傾ける)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double Cant { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Structure.Load(FilePath);
    /// </summary>
    public partial class StructureLoadStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Structure;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Load;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：このファイルからストラクチャーリストファイルへの相対パス
        /// </summary>
        [Argument]
        public string FilePath { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Structure[StructureKey].Put(TrackKey, X, Y, Z, RX, RY, RZ, Tilt, Span);
    /// </summary>
    public partial class StructurePutStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Structure;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Put;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：StructureKey
        /// </summary>
        public string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：配置先の軌道名 (0: 自軌道)
        /// </summary>
        [Argument]
        public string TrackKey { get; set; }

        /// <summary>
        /// 引数：軌道からの x 座標 [m]
        /// </summary>
        [Argument]
        public double X { get; set; }

        /// <summary>
        /// 引数：軌道からの y 座標 [m]
        /// </summary>
        [Argument]
        public double Y { get; set; }

        /// <summary>
        /// 引数：軌道からの z 座標 [m]
        /// </summary>
        [Argument]
        public double Z { get; set; }

        /// <summary>
        /// 引数：軌道に対する x 軸回りの角 [deg]
        /// </summary>
        [Argument]
        public double RX { get; set; }

        /// <summary>
        /// 引数：軌道に対する y 軸回りの角 [deg]
        /// </summary>
        [Argument]
        public double RY { get; set; }

        /// <summary>
        /// 引数：軌道に対する z 軸回りの角 [deg]
        /// </summary>
        [Argument]
        public double RZ { get; set; }

        /// <summary>
        /// 引数：傾斜オプション (0: 常に水平, 1: 勾配に連動, 2: カントに連動, 3: 勾配とカントに連動)
        /// </summary>
        [Argument]
        public double Tilt { get; set; }

        /// <summary>
        /// 引数：曲線における弦の長さ [m]
        /// </summary>
        [Argument]
        public double Span { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Structure[StructureKey].Put0(TrackKey, Tilt, Span);
    /// </summary>
    public partial class StructurePut0Statement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Structure;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Put0;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：StructureKey
        /// </summary>
        public string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：配置先の軌道名 (0: 自軌道)
        /// </summary>
        [Argument]
        public string TrackKey { get; set; }

        /// <summary>
        /// 引数：傾斜オプション (0: 常に水平, 1: 勾配に連動, 2: カントに連動, 3: 勾配とカントに連動)
        /// </summary>
        [Argument]
        public double Tilt { get; set; }

        /// <summary>
        /// 引数：曲線における弦の長さ [m]
        /// </summary>
        [Argument]
        public double Span { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Structure[StructureKey].Putbetween(TrackKey1, TrackKey2, Flag?);
    /// </summary>
    public partial class StructurePutbetweenStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Structure;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Putbetween;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：StructureKey
        /// </summary>
        public string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：一方の軌道の軌道名 (0: 自軌道)
        /// </summary>
        [Argument]
        public string TrackKey1 { get; set; }

        /// <summary>
        /// 引数：他方の軌道の軌道名
        /// </summary>
        [Argument]
        public string TrackKey2 { get; set; }

        /// <summary>
        /// 引数：変形方向 (0: x および y 方向に変形, 1: x 方向のみに変形)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double Flag { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Repeater[RepeaterKey].Begin(TrackKey, X, Y, Z, RX, RY, RZ, Tilt, Span, Interval);
    /// </summary>
    public partial class RepeaterBeginStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Repeater;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Begin;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：RepeaterKey
        /// </summary>
        public string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：配置先の軌道名 (0: 自軌道)
        /// </summary>
        [Argument]
        public string TrackKey { get; set; }

        /// <summary>
        /// 引数：軌道からの x 座標 [m]
        /// </summary>
        [Argument]
        public double X { get; set; }

        /// <summary>
        /// 引数：軌道からの y 座標 [m]
        /// </summary>
        [Argument]
        public double Y { get; set; }

        /// <summary>
        /// 引数：軌道からの z 座標 [m]
        /// </summary>
        [Argument]
        public double Z { get; set; }

        /// <summary>
        /// 引数：軌道に対する x 軸回りの角 [deg]
        /// </summary>
        [Argument]
        public double RX { get; set; }

        /// <summary>
        /// 引数：軌道に対する y 軸回りの角 [deg]
        /// </summary>
        [Argument]
        public double RY { get; set; }

        /// <summary>
        /// 引数：軌道に対する z 軸回りの角 [deg]
        /// </summary>
        [Argument]
        public double RZ { get; set; }

        /// <summary>
        /// 引数：傾斜オプション (0: 常に水平, 1: 勾配に連動, 2: カントに連動, 3: 勾配とカントに連動)
        /// </summary>
        [Argument]
        public double Tilt { get; set; }

        /// <summary>
        /// 引数：曲線における弦の長さ [m]
        /// </summary>
        [Argument]
        public double Span { get; set; }

        /// <summary>
        /// 引数：配置間隔 [m]
        /// </summary>
        [Argument]
        public double Interval { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Repeater[RepeaterKey].Begin0(TrackKey, Tilt, Span, Interval);
    /// </summary>
    public partial class RepeaterBegin0Statement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Repeater;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Begin0;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：RepeaterKey
        /// </summary>
        public string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：配置先の軌道名 (0: 自軌道)
        /// </summary>
        [Argument]
        public string TrackKey { get; set; }

        /// <summary>
        /// 引数：傾斜オプション (0: 常に水平, 1: 勾配に連動, 2: カントに連動, 3: 勾配とカントに連動)
        /// </summary>
        [Argument]
        public double Tilt { get; set; }

        /// <summary>
        /// 引数：曲線における弦の長さ [m]
        /// </summary>
        [Argument]
        public double Span { get; set; }

        /// <summary>
        /// 引数：配置間隔 [m]
        /// </summary>
        [Argument]
        public double Interval { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Repeater[RepeaterKey].End();
    /// </summary>
    public partial class RepeaterEndStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Repeater;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.End;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：RepeaterKey
        /// </summary>
        public string Key { get; set; }


    }

    /// <summary>
    /// Background.Change(StructureKey);
    /// </summary>
    public partial class BackgroundChangeStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Background;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Change;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：ストラクチャー名
        /// </summary>
        [Argument]
        public string StructureKey { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Station.Load(FilePath);
    /// </summary>
    public partial class StationLoadStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Station;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Load;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：このファイルから停車場リストファイルへの相対パス
        /// </summary>
        [Argument]
        public string FilePath { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Station[StationKey].Put(Door, Margin1, Margin2);
    /// </summary>
    public partial class StationPutStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Station;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Put;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：StationKey
        /// </summary>
        public string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：開くドアの方向 (-1: 左, 1: 右)
        /// </summary>
        [Argument]
        public double Door { get; set; }

        /// <summary>
        /// 引数：停止位置誤差の後方許容範囲 (負の値で設定)
        /// </summary>
        [Argument]
        public double Margin1 { get; set; }

        /// <summary>
        /// 引数：停止位置誤差の後方許容範囲
        /// </summary>
        [Argument]
        public double Margin2 { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Section.Begin();
    /// </summary>
    public partial class SectionBeginStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Section;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Begin;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo


    }

    /// <summary>
    /// Section.Beginnew();
    /// </summary>
    public partial class SectionBeginnewStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Section;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Beginnew;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo


    }

    /// <summary>
    /// Section.Setspeedlimit();
    /// </summary>
    public partial class SectionSetspeedlimitStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Section;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Setspeedlimit;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo


    }

    /// <summary>
    /// Signal.Speedlimit();
    /// </summary>
    public partial class SignalSpeedlimitStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Signal;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Speedlimit;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo


    }

    /// <summary>
    /// Signal.Load(FilePath);
    /// </summary>
    public partial class SignalLoadStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Signal;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Load;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：このファイルから信号現示リストファイルへの相対パス
        /// </summary>
        [Argument]
        public string FilePath { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Signal[SignalAspectKey].Put(Section, TrackKey, X, Y, Z?, RX?, RY?, RZ?, Tilt?, Span?);
    /// </summary>
    public partial class SignalPutStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Signal;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Put;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：SignalAspectKey
        /// </summary>
        public string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：関連づける閉そくの相対インデックス
        /// </summary>
        [Argument]
        public double Section { get; set; }

        /// <summary>
        /// 引数：配置先の軌道名
        /// </summary>
        [Argument]
        public string TrackKey { get; set; }

        /// <summary>
        /// 引数：軌道からの x 座標 [m]
        /// </summary>
        [Argument]
        public double X { get; set; }

        /// <summary>
        /// 引数：軌道からの y 座標 [m]
        /// </summary>
        [Argument]
        public double Y { get; set; }

        /// <summary>
        /// 引数：軌道からの z 座標 [m]（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double Z { get; set; }

        /// <summary>
        /// 引数：軌道に対する x 軸回りの角 [deg]（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double RX { get; set; }

        /// <summary>
        /// 引数：軌道に対する y 軸回りの角 [deg]（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double RY { get; set; }

        /// <summary>
        /// 引数：軌道に対する z 軸回りの角 [deg]（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double RZ { get; set; }

        /// <summary>
        /// 引数：傾斜オプション (0: 常に水平, 1: 勾配に連動, 2: カントに連動, 3: 勾配とカントに連動)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double Tilt { get; set; }

        /// <summary>
        /// 引数：曲線における弦の長さ [m]（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double Span { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Beacon.Put(Type, Section, Senddata);
    /// </summary>
    public partial class BeaconPutStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Beacon;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Put;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：保安装置に送る地上子種別 (整数)
        /// </summary>
        [Argument]
        public double Type { get; set; }

        /// <summary>
        /// 引数：関連づける閉そくの相対インデックス
        /// </summary>
        [Argument]
        public double Section { get; set; }

        /// <summary>
        /// 引数：保安装置に送る値 (整数)
        /// </summary>
        [Argument]
        public double Senddata { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Speedlimit.Begin(V);
    /// </summary>
    public partial class SpeedlimitBeginStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Speedlimit;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Begin;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：走行速度 [km/h]
        /// </summary>
        [Argument]
        public double V { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Speedlimit.End();
    /// </summary>
    public partial class SpeedlimitEndStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Speedlimit;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.End;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo


    }

    /// <summary>
    /// Pretrain.Pass(Time?, Second?);
    /// </summary>
    public partial class PretrainPassStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Pretrain;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Pass;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：時刻を表す文字列 ('hh:mm:ss')（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public string Time { get; set; }

        /// <summary>
        /// 引数：00:00:00 からの経過時間 [sec]（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double Second { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Light.Ambient(Red, Green, Blue);
    /// </summary>
    public partial class LightAmbientStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Light;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Ambient;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：赤成分 (0 ~ 1)
        /// </summary>
        [Argument]
        public double Red { get; set; }

        /// <summary>
        /// 引数：緑成分 (0 ~ 1)
        /// </summary>
        [Argument]
        public double Green { get; set; }

        /// <summary>
        /// 引数：青成分 (0 ~ 1)
        /// </summary>
        [Argument]
        public double Blue { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Light.Diffuse(Red, Green, Blue);
    /// </summary>
    public partial class LightDiffuseStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Light;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Diffuse;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：赤成分 (0 ~ 1)
        /// </summary>
        [Argument]
        public double Red { get; set; }

        /// <summary>
        /// 引数：緑成分 (0 ~ 1)
        /// </summary>
        [Argument]
        public double Green { get; set; }

        /// <summary>
        /// 引数：青成分 (0 ~ 1)
        /// </summary>
        [Argument]
        public double Blue { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Fog.Interpolate(Density?, Red?, Green?, Blue?);
    /// </summary>
    public partial class FogInterpolateStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Fog;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Interpolate;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：濃度（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double Density { get; set; }

        /// <summary>
        /// 引数：赤成分 (0 ~ 1)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double Red { get; set; }

        /// <summary>
        /// 引数：緑成分 (0 ~ 1)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double Green { get; set; }

        /// <summary>
        /// 引数：青成分 (0 ~ 1)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double Blue { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Fog.Set(Density?, Red?, Green?, Blue?);
    /// </summary>
    public partial class FogSetStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Fog;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Set;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：濃度（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double Density { get; set; }

        /// <summary>
        /// 引数：赤成分 (0 ~ 1)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double Red { get; set; }

        /// <summary>
        /// 引数：緑成分 (0 ~ 1)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double Green { get; set; }

        /// <summary>
        /// 引数：青成分 (0 ~ 1)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double Blue { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Drawdistance.Change(Value);
    /// </summary>
    public partial class DrawdistanceChangeStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Drawdistance;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Change;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：距離 [m] (0: [設定] ウィンドウで設定される描画距離を適用)
        /// </summary>
        [Argument]
        public double Value { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Cabilluminance.Interpolate(Value?);
    /// </summary>
    public partial class CabilluminanceInterpolateStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Cabilluminance;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Interpolate;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：昼間画像と夜間画像の混合比 (0: 夜間画像 ~ 1: 昼間画像)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double Value { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Cabilluminance.Set(Value?);
    /// </summary>
    public partial class CabilluminanceSetStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Cabilluminance;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Set;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：昼間画像と夜間画像の混合比 (0: 夜間画像 ~ 1: 昼間画像)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double Value { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Irregularity.Change(X, Y, R, LX, LY, LR);
    /// </summary>
    public partial class IrregularityChangeStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Irregularity;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Change;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：左右変位 (左と右のレールの通り変位の平均に相当) の標準偏差 [m]
        /// </summary>
        [Argument]
        public double X { get; set; }

        /// <summary>
        /// 引数：上下変位 (左と右のレールの高低変位の平均に相当) の標準偏差 [m]
        /// </summary>
        [Argument]
        public double Y { get; set; }

        /// <summary>
        /// 引数：ロール変位 (水準変位を軌間で除した値に相当) の標準偏差 [rad]
        /// </summary>
        [Argument]
        public double R { get; set; }

        /// <summary>
        /// 引数：左右変位の遮断波長 [m]
        /// </summary>
        [Argument]
        public double LX { get; set; }

        /// <summary>
        /// 引数：上下変位の遮断波長 [m]
        /// </summary>
        [Argument]
        public double LY { get; set; }

        /// <summary>
        /// 引数：ロール変位の遮断波長 [m]
        /// </summary>
        [Argument]
        public double LR { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Adhesion.Change(A, B?, C?);
    /// </summary>
    public partial class AdhesionChangeStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Adhesion;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Change;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：走行速度 0 km/h における粘着係数
        /// </summary>
        [Argument]
        public double A { get; set; }

        /// <summary>
        /// 引数：粘着係数の走行速度に対する変化を表す係数（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double B { get; set; }

        /// <summary>
        /// 引数：粘着係数の走行速度に対する変化を表す係数（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double C { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Sound.Load(FilePath);
    /// </summary>
    public partial class SoundLoadStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Sound;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Load;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：このファイルからサウンドリストファイルへの相対パス
        /// </summary>
        [Argument]
        public string FilePath { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Sound[SoundKey].Play();
    /// </summary>
    public partial class SoundPlayStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Sound;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Play;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：SoundKey
        /// </summary>
        public string Key { get; set; }


    }

    /// <summary>
    /// Sound3d.Load(FilePath);
    /// </summary>
    public partial class Sound3dLoadStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Sound3d;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Load;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：このファイルからサウンドリストファイルへの相対パス
        /// </summary>
        [Argument]
        public string FilePath { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Sound3d[SoundKey].Put(X, Y);
    /// </summary>
    public partial class Sound3dPutStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Sound3d;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Put;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：SoundKey
        /// </summary>
        public string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：軌道からの x 座標 [m]
        /// </summary>
        [Argument]
        public double X { get; set; }

        /// <summary>
        /// 引数：軌道からの y 座標 [m]
        /// </summary>
        [Argument]
        public double Y { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Rollingnoise.Change(Index);
    /// </summary>
    public partial class RollingnoiseChangeStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Rollingnoise;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Change;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：車両サウンドファイルの [Run] セクションで定義したインデックス
        /// </summary>
        [Argument]
        public double Index { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Flangenoise.Change(Index);
    /// </summary>
    public partial class FlangenoiseChangeStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Flangenoise;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Change;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：車両サウンドファイルの [Flange] セクションで定義したインデックス
        /// </summary>
        [Argument]
        public double Index { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Jointnoise.Play(Index);
    /// </summary>
    public partial class JointnoisePlayStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Jointnoise;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Play;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：車両サウンドファイルの [Joint] セクションで定義したインデックス
        /// </summary>
        [Argument]
        public double Index { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Train.Add(TrainKey, FilePath, TrackKey, Direction);
    /// </summary>
    public partial class TrainAddStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Train;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Add;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：他列車名 (任意の文字列)
        /// </summary>
        [Argument]
        public string TrainKey { get; set; }

        /// <summary>
        /// 引数：このファイルから他列車ファイルへの相対パス
        /// </summary>
        [Argument]
        public string FilePath { get; set; }

        /// <summary>
        /// 引数：走行する軌道
        /// </summary>
        [Argument]
        public string TrackKey { get; set; }

        /// <summary>
        /// 引数：進行方向 (-1: 対向, 1: 並走)
        /// </summary>
        [Argument]
        public double Direction { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Train[TrainKey].Load(FilePath, TrackKey, Direction);
    /// </summary>
    public partial class TrainLoadStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Train;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Load;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：TrainKey
        /// </summary>
        public string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：このファイルから他列車ファイルへの相対パス
        /// </summary>
        [Argument]
        public string FilePath { get; set; }

        /// <summary>
        /// 引数：走行する軌道
        /// </summary>
        [Argument]
        public string TrackKey { get; set; }

        /// <summary>
        /// 引数：進行方向 (-1: 対向, 1: 並走)
        /// </summary>
        [Argument]
        public double Direction { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Train[TrainKey].Enable(Time?, Second?);
    /// </summary>
    public partial class TrainEnableStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Train;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Enable;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：TrainKey
        /// </summary>
        public string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：時刻を表す文字列 ('hh:mm:ss')（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public string Time { get; set; }

        /// <summary>
        /// 引数：00:00:00 からの経過時間 [sec]（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double Second { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Train[TrainKey].Stop(Decelerate, StopTime, Accelerate, Speed);
    /// </summary>
    public partial class TrainStopStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Train;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Stop;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：TrainKey
        /// </summary>
        public string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：減速度 [km/h/s]
        /// </summary>
        [Argument]
        public double Decelerate { get; set; }

        /// <summary>
        /// 引数：停車時間 [s]
        /// </summary>
        [Argument]
        public double StopTime { get; set; }

        /// <summary>
        /// 引数：加速度 [km/h/s]
        /// </summary>
        [Argument]
        public double Accelerate { get; set; }

        /// <summary>
        /// 引数：加速後の走行速度 [km/h]
        /// </summary>
        [Argument]
        public double Speed { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Legacy.Fog(Fogstart, Fogend, red, green, blue);
    /// </summary>
    public partial class LegacyFogStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Legacy;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Fog;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：視界が100%の距離 [m]
        /// </summary>
        [Argument]
        public double Fogstart { get; set; }

        /// <summary>
        /// 引数：視界が0%になる距離 [m]
        /// </summary>
        [Argument]
        public double Fogend { get; set; }

        /// <summary>
        /// 引数：赤成分 (0 ~ 1)
        /// </summary>
        [Argument]
        public double red { get; set; }

        /// <summary>
        /// 引数：緑成分 (0 ~ 1)
        /// </summary>
        [Argument]
        public double green { get; set; }

        /// <summary>
        /// 引数：青成分 (0 ~ 1)
        /// </summary>
        [Argument]
        public double blue { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Legacy.Curve(radius, cant);
    /// </summary>
    public partial class LegacyCurveStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Legacy;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Curve;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：曲線半径 [m] (正: 右曲線, 負: 左曲線)
        /// </summary>
        [Argument]
        public double radius { get; set; }

        /// <summary>
        /// 引数：カント [m]
        /// </summary>
        [Argument]
        public double cant { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Legacy.Pitch(rate);
    /// </summary>
    public partial class LegacyPitchStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Legacy;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Pitch;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：勾配 [‰]
        /// </summary>
        [Argument]
        public double rate { get; set; }
        #endregion Args

    }

    /// <summary>
    /// Legacy.Turn(slope);
    /// </summary>
    public partial class LegacyTurnStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Legacy;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName FunctionName => MapFunctionName.Turn;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：傾き(+: 右, -: 左)
        /// </summary>
        [Argument]
        public double slope { get; set; }
        #endregion Args

    }
}