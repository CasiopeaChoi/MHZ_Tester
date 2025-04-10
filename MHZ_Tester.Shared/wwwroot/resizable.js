window.initSidebarResize = (selector, handleSelector) => {
    const sidebar = document.querySelector(selector);
    const handle = document.querySelector(handleSelector);

    const onMouseMove = (e) => {
        const newWidth = e.clientX;
        sidebar.style.width = `${newWidth}px`;
    };

    const onMouseUp = () => {
        document.removeEventListener('mousemove', onMouseMove);
        document.removeEventListener('mouseup', onMouseUp);
    };

    const onMouseDown = (e) => {
        e.preventDefault();
        document.addEventListener('mousemove', onMouseMove);
        document.addEventListener('mouseup', onMouseUp);
    };

    handle.addEventListener('mousedown', onMouseDown);
};