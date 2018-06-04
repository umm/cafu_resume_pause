using System;
using CAFU.Core.Presentation.Presenter;

namespace CAFU.ResumePause.Presentation.Presenter
{
    public interface IResumePausePresenter : IPresenter
    {
        void Resume();

        void Pause();

        bool IsPlaying { get; }

        IObservable<bool> IsPlayingAsObservable { get; }
    }

    public static class IResumePausePresenterExtension
    {
        /// <summary>
        /// Switch Pause or Resume.
        /// </summary>
        /// <returns>true if playing</returns>
        public static bool ResumeOrPause(this IResumePausePresenter presenter)
        {
            if (presenter.IsPlaying)
            {
                presenter.Pause();
            }
            else
            {
                presenter.Resume();
            }

            return presenter.IsPlaying;
        }
    }
}