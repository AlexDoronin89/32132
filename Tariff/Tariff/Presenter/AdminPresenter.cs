using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tariff.model;

namespace Tariff.Presenter
{
    class AdminPresenter
    {
        private TariffData _model;
        private AdminForm _view;

        public AdminPresenter(TariffData model, AdminForm view)
        {
            _model = model;
            _view = view;

            _model.AddedTariff += OnAddedTariff;
            _model.RemovedTariff += OnRemovedTariff;
            _model.UpdatedTariff += OnUpdatedTariff;

            _view.AddingTariff += OnAddingTariff;
            _view.RemovingTariff += OnRemovingTariff;
            _view.GettingAllTariffs += OnGettingAllTariffs;
            _view.UpdatingTariff += OnUpdatingTariff;
            _view.Saving += OnSaving;

            _view.RefreshListBox();
        }

        private void OnSaving() => _model.Save();

        private IReadOnlyList<IReadOnlyTariff> OnGettingAllTariffs() => _model.GetTariffs();

        //private void OnUpdatedTariff() => _view.
        private void OnUpdatingTariff(int gygabytes, int minutes, int messages, int price, int index, string name) 
            => _model.UpdateTariff(index, price, name, gygabytes, messages, minutes);

        private void OnUpdatedTariff()
        {
            _view.RefreshListBox();
        }


        private void OnAddedTariff() => _view.RefreshListBox();

        private void OnAddingTariff(int gygabytes, int minutes, int messages, int price, string name) => _model.AddTariff(gygabytes, minutes, messages, price, name);
       
        private void OnRemovedTariff() => _view.RefreshListBox();

        private void OnRemovingTariff(int id) => _model.RemoveTariff(id);


    }
}
