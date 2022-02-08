using System;


namespace Autotest_Multiplex.Tests.Rozetka.PageObject
{
    public partial class FindPan
    {
        public readonly string _seacher = "//*[contains(@class, 'search-form__input ng-untouched ng-pristine ng-valid')]";
        public readonly string _btnsearch = "//*[text()=' Знайти ']";
        public readonly string _btnCit = "//*[contains(@class, 'geo')]";
    }
}
