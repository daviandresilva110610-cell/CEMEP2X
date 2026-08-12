document.addEventListener('DOMContentLoaded', () => {
    // 1. Inicializar Ícones Lucide
    lucide.createIcons();

    // 2. Menu Mobile Responsive Toggle
    const menuToggle = document.getElementById('menuToggle');
    const navMenu = document.getElementById('navMenu');
    const iconOpen = menuToggle.querySelector('.icon-open');
    const iconClose = menuToggle.querySelector('.icon-close');

    menuToggle.addEventListener('click', () => {
        navMenu.classList.toggle('active');
        const isOpen = navMenu.classList.contains('active');

        if (isOpen) {
            iconOpen.style.display = 'none';
            iconClose.style.display = 'block';
        } else {
            iconOpen.style.display = 'block';
            iconClose.style.display = 'none';
        }
    });

    // Fechar menu mobile ao clicar num link
    const navLinks = document.querySelectorAll('.nav-link');
    navLinks.forEach(link => {
        link.addEventListener('click', () => {
            navMenu.classList.remove('active');
            iconOpen.style.display = 'block';
            iconClose.style.display = 'none';
        });
    });

    // 3. Lógica do Carrossel de Veículos
    const track = document.querySelector('.carousel-track');
    const slides = Array.from(track.children);
    const nextBtn = document.getElementById('nextBtn');
    const prevBtn = document.getElementById('prevBtn');
    const dotsNav = document.querySelector('.carousel-nav');
    const dots = Array.from(dotsNav.children);

    let currentIndex = 0;
    let autoSlideTimer;

    // Atualiza posição do carrossel
    const updateCarousel = (index) => {
        track.style.transform = `translateX(-${index * 100}%)`;

        // Atualiza indicadores (dots)
        dots.forEach(dot => dot.classList.remove('active'));
        dots[index].classList.add('active');

        currentIndex = index;
    };

    // Botão Próximo
    nextBtn.addEventListener('click', () => {
        const nextIndex = (currentIndex + 1) % slides.length;
        updateCarousel(nextIndex);
        resetAutoSlide();
    });

    // Botão Anterior
    prevBtn.addEventListener('click', () => {
        const prevIndex = (currentIndex - 1 + slides.length) % slides.length;
        updateCarousel(prevIndex);
        resetAutoSlide();
    });

    // Navegação via Indicadores (Dots)
    dotsNav.addEventListener('click', e => {
        const targetDot = e.target.closest('.carousel-indicator');
        if (!targetDot) return;

        const targetIndex = dots.findIndex(dot => dot === targetDot);
        updateCarousel(targetIndex);
        resetAutoSlide();
    });

    // Rotação Automática (Autoplay)
    const startAutoSlide = () => {
        autoSlideTimer = setInterval(() => {
            const nextIndex = (currentIndex + 1) % slides.length;
            updateCarousel(nextIndex);
        }, 5000); // Muda a cada 5 segundos
    };

    const resetAutoSlide = () => {
        clearInterval(autoSlideTimer);
        startAutoSlide();
    };

    // Pausar autoplay ao passar o mouse por cima
    const carouselContainer = document.getElementById('carrosselVeiculos');
    carouselContainer.addEventListener('mouseenter', () => clearInterval(autoSlideTimer));
    carouselContainer.addEventListener('mouseleave', startAutoSlide);

    // Iniciar autoplay
    startAutoSlide();
});